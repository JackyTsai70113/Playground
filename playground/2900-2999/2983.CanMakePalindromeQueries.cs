namespace playground;

public class CanMakePalindromeQueries2983
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-rearrangement-queries
    /// </summary>
    public static bool[] CanMakePalindromeQueries(string s, int[][] A)
    {
        int n = s.Length;
        var chs = new int[26];
        var res = new bool[A.Length];
        for (int i = 0; i < s.Length / 2; i++)
        {
            chs[s[i] - 'a']++;
            chs[s[n - 1 - i] - 'a']--;
        }
        if (chs.Any(x => x != 0)) return res;

        var t = new string(s.Reverse().Take(n / 2).ToArray());
        for (int i = 0; i < A.Length; ++i)
        {
            res[i] = true;
            var a = A[i];
            (a[2], a[3]) = (n - 1 - a[3], n - 1 - a[2]);
            for (int j = 0; res[i] && j < Math.Min(a[0], a[2]); j++)
            {
                if (s[j] != t[j]) res[i] = false;
            }
            for (int j = Math.Min(a[1], a[3]) + 1; res[i] && j < Math.Max(a[0], a[2]); j++)
            {
                if (s[j] != t[j]) res[i] = false;
            }
            for (int j = Math.Max(a[1], a[3]) + 1; res[i] && j < n / 2; j++)
            {
                if (s[j] != t[j]) res[i] = false;
            }
        }
        return res;
    }
}
