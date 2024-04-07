namespace playground;

public class MinOperationsToMakeMedianK3107
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-median-of-array-equal-to-k
    /// </summary>
    public static long MinOperationsToMakeMedianK(int[] nums, int k)
    {
        Array.Sort(nums);
        if (nums[nums.Length / 2] == k)
            return 0;
        long res = 0;
        if (nums[nums.Length / 2] < k)
        {
            for (int i = nums.Length / 2; i < nums.Length; i++)
            {
                if (nums[i] <= k)
                {
                    res += k - nums[i];
                }
            }
        }
        else if (nums[nums.Length / 2] > k)
        {
            for (int i = 0; i <= nums.Length / 2; i++)
            {
                if (nums[i] >= k)
                {
                    res += nums[i] - k;
                }
            }
        }
        return res;
    }
}
