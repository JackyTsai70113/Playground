namespace playground.DynamicProgramming;

public class NumberOfArraysClass
{
    /// <remarks>https://leetcode.com/problems/restore-the-array</remarks>
    public static int NumberOfArrays(string s, int k)
    {
        int mod = (int)(1e9 + 7);
        int n = s.Length;
        int m = k.ToString().Length;
        var dp = new int[m + 1];
        dp[0] = 1;
        for (int start = 0; start < n; ++start)
        {
            if (s[start] == '0')
            {
                dp[start % (m + 1)] = 0;
                continue;
            }
            for (int end = start; end < n && end <= start + m; ++end)
            {
                if (long.Parse(s.Substring(start, end - start + 1)) <= k)
                {
                    dp[(end + 1) % (m + 1)] = (dp[(end + 1) % (m + 1)] + dp[start % (m + 1)]) % mod;
                }
            }
            dp[start % (m + 1)] = 0;
        }
        return dp[n % (m + 1)];
    }
}
