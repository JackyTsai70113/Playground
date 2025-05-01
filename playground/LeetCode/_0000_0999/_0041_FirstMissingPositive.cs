namespace playground.LeetCode._0000_0999;

public class _0041_FirstMissingPositive
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive
    /// </summary>
    public static int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] >= 1 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
            {
                var index = nums[i] - 1;
                (nums[i], nums[index]) = (nums[index], nums[i]);
            }
        }
        var res = nums.Length + 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                res = i + 1;
                break;
            }
        }
        return res;
    }
}
