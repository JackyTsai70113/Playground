namespace playground.LeetCode._0000_0999;

public class _0053_MaxSubArray
{
    public static int MaxSubArray(int[] nums)
    {
        int sum = 0, res = int.MinValue;
        foreach (var num in nums)
        {
            res = Math.Max(res, sum + num);
            sum = Math.Max(0, sum + num);
        }
        return res;
    }

    public static int MaxSubArray2(int[] nums)
    {
        var dp = new int[nums.Length];
        dp[0] = nums[0];
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
            max = Math.Max(max, dp[i]);
        }
        return max;
    }
}