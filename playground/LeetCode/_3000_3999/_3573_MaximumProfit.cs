namespace playground.LeetCode._3000_3999;

public class _3573_MaximumProfit
{
    public static long MaximumProfit(int[] A, int k)
    {
        int n = A.Length;
        var dp = new long[k + 1, n, 3];
        for (int t = 0; t <= k; t++)
        {
            for (int d = 0; d < n; d++)
            {
                dp[t, d, 0] = long.MinValue / 2;
                dp[t, d, 1] = long.MinValue / 2;
                dp[t, d, 2] = long.MinValue / 2;
            }
        }

        dp[0, 0, 0] = 0;
        dp[0, 0, 1] = -A[0];
        dp[0, 0, 2] = A[0];

        for (int d = 1; d < n; d++)
        {
            for (int t = 0; t <= k; t++)
            {
                long a =
                    t > 0 && dp[t - 1, d - 1, 1] != long.MinValue / 2 ?
                    dp[t - 1, d - 1, 1] + A[d] :
                    long.MinValue / 2;
                long b =
                    t > 0 && dp[t - 1, d - 1, 2] != long.MinValue / 2 ?
                    dp[t - 1, d - 1, 2] - A[d] :
                    long.MinValue / 2;
                dp[t, d, 0] = Math.Max(dp[t, d - 1, 0],
                    Math.Max(a, b));
                dp[t, d, 1] = Math.Max(
                    dp[t, d - 1, 1], dp[t, d - 1, 0] - A[d]
                );
                dp[t, d, 2] = Math.Max(
                    dp[t, d - 1, 2], dp[t, d - 1, 0] + A[d]
                );
            }
        }
        long max = 0;
        for (int t = 0; t <= k; t++)
        {
            max = Math.Max(max, dp[t, n - 1, 0]);
        }
        return max;
    }
}
