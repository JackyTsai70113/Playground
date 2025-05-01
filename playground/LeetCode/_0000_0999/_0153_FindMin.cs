namespace playground.LeetCode._0000_0999;

public class _0153_FindMin
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
    /// </summary>
    public static int FindMin(int[] nums)
    {
        int n = nums.Length, l = 0, r = n - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] < nums[r])
                r = m;
            else
                l = m + 1;
        }
        return nums[l];
    }
}
