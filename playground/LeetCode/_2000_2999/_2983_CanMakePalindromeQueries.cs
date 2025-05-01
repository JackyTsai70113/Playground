namespace playground.LeetCode._2000_2999;

public class _2983_CanMakePalindromeQueries
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-rearrangement-queries
    /// </summary>
    public static bool[] CanMakePalindromeQueries(string s, int[][] A)
    {
        int n = s.Length;
        string s1 = s[..(n / 2)], s2 = new(s[(n / 2)..].Reverse().ToArray());
        var res = new bool[A.Length];

        var binds = new List<(int left, int right)>();
        var indexes = new int[26];
        for (int i = 0; i < n / 2; i++)
        {
            bool found = false;
            for (int j = indexes[s1[i] - 'a']; j < n / 2; j++)
            {
                if (s1[i] == s2[j])
                {
                    indexes[s1[i] - 'a'] = j + 1;
                    if (i != j)
                    {
                        binds.Add((i, j));
                    }
                    found = true;
                    break;
                }
            }
            if (!found)
                return res;
        }
        for (int i = 0; i < A.Length; ++i)
        {
            res[i] = true;
            int l1 = A[i][0], r1 = A[i][1];
            int l2 = n - 1 - A[i][3], r2 = n - 1 - A[i][2];

            foreach (var (left, right) in binds)
            {
                (int left, int right) range1 = (left, left);
                (int left, int right) range2 = (right, right);
                if (left >= l1 && left <= r1)
                    range1 = (l1, r1);
                if (right >= l2 && right <= r2)
                    range2 = (l2, r2);
                if (range1.left > range2.right || range2.left > range1.right)
                {
                    res[i] = false;
                    break;
                }
            }
        }
        return res;
    }
}
