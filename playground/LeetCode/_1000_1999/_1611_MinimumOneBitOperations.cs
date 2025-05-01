namespace playground;

public class _1611_MinimumOneBitOperations
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-one-bit-operations-to-make-integers-zero
    /// </summary>
    public static int MinimumOneBitOperations(int n)
    {
        var dp = new Dictionary<int, int>();
        dp[0] = 0;
        int dfs(int n)
        {
            if (!dp.ContainsKey(n))
            {
                int b = 1;
                while ((b << 1) <= n)
                {
                    b <<= 1;
                }
                dp[n] = dfs(b ^ (b >> 1) ^ n) + b;
            }
            return dp[n];
        }
        return dfs(n);
    }
}
