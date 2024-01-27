namespace playground;

public class KInversePairs0629
{
    /// <summary>
    /// https://leetcode.com/problems/k-inverse-pairs-array
    /// </summary>
    public static int KInversePairs(int n, int k)
    {
        if (k == 0) return 1;
        if (k > n * (n - 1) / 2) return 0;
        long MOD = (long)1e9 + 7;
        long[] memo = new long[k + 1], presum = new long[k + 1];
        memo[0] = 1; presum[0] = 1;
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= Math.Min(k, i * (i + 1) / 2); j++)
            {
                presum[j] = memo[j] + presum[j - 1];
                memo[j] = (presum[j] + MOD - (j - i - 1 >= 0 ? presum[j - i - 1] : 0)) % MOD;
            }
        }
        return (int)memo[k];
    }
}
