namespace playground.LeetCode._1000_1999;

public class _1638_CountSubstrings
{
    public static int CountSubstrings(string s, string t)
    {
        if (s.Length < t.Length)
            return CountSubstrings(t, s);
        int m = s.Length, n = t.Length;
        var same = new int[n + 1];
        var diff = new int[n + 1];
        int res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                bool equal = s[i] == t[j];
                if (equal)
                {
                    diff[j + 1] = diff[j];
                    same[j + 1] = same[j] + 1;
                }
                else
                {
                    diff[j + 1] = same[j] + 1;
                    same[j + 1] = 0;
                }
                res += diff[j + 1];
            }
        }
        return res;
    }
}
