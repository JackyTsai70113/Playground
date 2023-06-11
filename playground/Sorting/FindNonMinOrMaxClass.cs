namespace playground.Sorting;

public class FindNonMinOrMaxClass
{
    /// <summary>
    /// https://leetcode.com/problems/third-maximum-number
    /// </summary>
    public static int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return -1;
        }
        Array.Sort(nums);
        return nums[1];
    }
}
