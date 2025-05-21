namespace playground.LeetCode._0000_0999;

public class _0813_LargestSumOfAverages
{
    public static double LargestSumOfAverages(int[] nums, int k)
    {
        int n = nums.Length;

        double[] presum = new double[n + 1];
        for (int i = 0; i < n; i++)
            presum[i + 1] = presum[i] + nums[i];

        double[] dp = new double[n];

        // 區分成一組
        for (int i = 0; i <= n - k; i++)
        {
            dp[i] = presum[i + 1] / (i + 1);
        }
        
        for (int i = 1; i < k; i++)
        {
            for (int curEnd = n - k + i; curEnd >= i; curEnd--)
            {
                for (int lastEnd = curEnd - 1; lastEnd >= i - 1; lastEnd--)
                {
                    var curAverage = (presum[curEnd + 1] - presum[lastEnd + 1]) / (curEnd - lastEnd);
                    dp[curEnd] = Math.Max(dp[curEnd], curAverage + dp[lastEnd]);
                }
            }
        }
        return dp[n - 1];
    }
}
