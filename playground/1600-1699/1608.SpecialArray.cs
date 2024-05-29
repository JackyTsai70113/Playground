namespace playground;

public class SpecialArray1608
{
    /// <summary>
    /// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x
    /// </summary>
    public static int SpecialArray(int[] nums)
    {
        Array.Sort(nums);
        if (nums[0] >= nums.Length)
            return nums.Length;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums.Length - i && nums.Length - i <= nums[i])
                return nums.Length - i;
        }
        return -1;
    }
}
