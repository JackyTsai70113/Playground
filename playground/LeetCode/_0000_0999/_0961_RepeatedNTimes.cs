namespace playground.LeetCode._0000_0999;

public class _0961_RepeatedNTimes
{
    /// <summary>
    /// https://leetcode.com/problems/n-repeated-element-in-size-2n-array
    /// </summary>
    public static int RepeatedNTimes(int[] nums)
    {
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i] || nums[i - 2] == nums[i])
            {
                return nums[i];
            }
        }
        return nums[0];
    }
}
