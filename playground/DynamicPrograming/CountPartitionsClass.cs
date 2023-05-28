namespace playground.DynamicPrograming;

public class CountPartitionsClass
{
    /// <remarks>https://leetcode.com/problems/number-of-great-partitions</remarks>
    public static int CountPartitions(int[] A, int k)
    {
        long mod = (long)1e9 + 7, total = 0, res = 1; long[] dp = new long[k];
        dp[0] = 1;
        foreach (int a in A)
        {
            for (int i = k - 1 - a; i >= 0; --i)
                dp[i + a] = (dp[i + a] + dp[i]) % mod;
            res = res * 2 % mod;
            total += a;
        }
        for (int i = 0; i < k; ++i)
            res -= total - i < k ? dp[i] : dp[i] * 2;
        return (int)((res % mod + mod) % mod);
    }
}
