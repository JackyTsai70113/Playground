namespace playground;

public class CanMakePalindromeQueries2983
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-rearrangement-queries
    /// </summary>
    public static bool[] CanMakePalindromeQueries(string s, int[][] A)
    {
        int n = s.Length / 2;
        string a = s.Substring(0, n), b = new string(s.Substring(n, n).Reverse().ToArray());
        var chs = new int[26];
        var res = new bool[A.Length];
        for (int i = 0; i < s.Length / 2; i++)
        {
            chs[s[i] - 'a']++;
            chs[s[n - 1 - i] - 'a']--;
        }

        var eqs = new int[n];
        for (int i = 0; i < n; i++)
        {
            eqs[i] += i > 0 ? eqs[i - 1] : 0;
            eqs[i] += a[i] == b[i] ? 1 : 0;
        }
        int[][] preA = new int[n][], preB = new int[n][];
        for (int i = 0; i < n; i++)
        {
            preA[i] = i > 0 ? preA[i - 1].ToArray() : new int[26];
            preB[i] = i > 0 ? preB[i - 1].ToArray() : new int[26];
            preA[i][a[i] - 'a']++;
            preB[i][b[i] - 'a']++;
        }
        for (int i = 0; i < A.Length; ++i)
        {
            res[i] = true;
            int l, r, l1 = A[i][0], r1 = A[i][1];
            int l2 = 2 * n - 1 - A[i][3], r2 = 2 * n - 1 - A[i][2];

            // the chars are equal which are not covered.
            // left
            r = Math.Min(l1, l2) - 1;
            if (r >= 0 && eqs[r] != r + 1)
            {
                res[i] = false;
                continue;
            }

            // right
            l = Math.Max(r1, r2); r = n - 1;
            if (r > l && eqs[r] - eqs[l] != r - l)
            {
                res[i] = false;
                continue;
            }

            // between
            if (r1 < l2 || r2 < l1)
            {
                l = Math.Min(r1, r2);
                r = Math.Max(l1, l2);
                if (r - l > 1 && eqs[r - 1] - eqs[l] != r - l - 1)
                {
                    res[i] = false;
                    continue;
                }
            }

            // the chars are anagram which are covered.
            int[] pa = preA[r1].ToArray(), pb = preB[r2].ToArray();
            for (int j = 0; j < 26; j++)
            {
                pa[j] -= l1 > 0 ? preA[l1 - 1][j] : 0;
                pb[j] -= l2 > 0 ? preB[l2 - 1][j] : 0;
            }

            // left
            if (l1 <= l2)
            {
                l = l1; r = Math.Min(r1, l2 - 1);
                if (r >= l)
                {
                    var p = preB[r].ToArray();
                    for (int j = 0; j < 26; j++) p[j] -= l > 0 ? preB[l - 1][j] : 0;
                    for (int j = 0; res[i] && j < 26; j++)
                    {
                        pa[j] -= p[j];
                        if (pa[j] < 0)
                            res[i] = false;
                    }
                    if (!res[i]) continue;
                }
            }
            else
            {
                l = l2; r = Math.Min(r2, l1 - 1);
                if (r >= l)
                {
                    var p = preA[r].ToArray();
                    for (int j = 0; j < 26; j++) p[j] -= l > 0 ? preA[l - 1][j] : 0;
                    for (int j = 0; res[i] && j < 26; j++)
                    {
                        pb[j] -= p[j];
                        if (pb[j] < 0)
                            res[i] = false;
                    }
                    if (!res[i]) continue;
                }
            }

            // right
            if (r1 >= r2)
            {
                l = Math.Max(l1, r2 + 1); r = r1;
                if (r >= l)
                {
                    var p = preB[r].ToArray();
                    for (int j = 0; j < 26; j++) p[j] -= preB[l - 1][j];
                    for (int j = 0; j < 26; j++)
                    {
                        pa[j] -= p[j];
                    }
                    if (!res[i]) continue;
                }
            }
            else
            {
                l = Math.Max(l2, r1 + 1); r = r2;
                if (r >= l)
                {
                    var p = preA[r].ToArray();
                    for (int j = 0; j < 26; j++) p[j] -= preA[l - 1][j];
                    for (int j = 0; j < 26; j++)
                    {
                        pb[j] -= p[j];
                        if (pb[j] < 0)
                            res[i] = false;
                    }
                    if (!res[i]) continue;
                }
            }

            // intersection: check if anagram
            for (int j = 0; j < 26; j++)
            {
                if (pa[j] != pb[j])
                    res[i] = false;
            }
        }
        return res;
    }
}
