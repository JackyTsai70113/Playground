namespace playground;

public class MinimumCost3010
{
    /// <summary>
    /// https://leetcode.com/problems/divide-an-array-into-subarrays-with-minimum-cost-i
    /// </summary>
    public static int MinimumCost(int[] nums)
    {
        var res = nums[0];
        nums = nums.Skip(1).ToArray();
        Array.Sort(nums);
        return res + nums[0] + nums[1];
    }
}
