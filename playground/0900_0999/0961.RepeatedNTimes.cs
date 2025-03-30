namespace playground;

public class RepeatedNTimes0961
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
