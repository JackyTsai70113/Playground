namespace playground.LeetCode._0000_0999;

public class _0115_NumDistinct
{
    /// <summary>
    /// https://leetcode.com/problems/distinct-subsequences
    /// </summary>
    public static int NumDistinct(string s, string t)
    {
        int m = s.Length, n = t.Length;
        var memo = new int[m];
        Array.Fill(memo, 1);
        for (int j = 0; j < n; j++)
        {
            var memo2 = new int[m];
            for (int i = j; i < m; i++)
            {
                if (s[i] == t[j])
                {
                    memo2[i] = i == 0 ? 1 : memo[i - 1] + memo2[i - 1];
                }
                else
                {
                    memo2[i] = i == 0 ? 0 : memo2[i - 1];
                }
            }
            memo = memo2;
        }
        return memo[m - 1];
    }
}
