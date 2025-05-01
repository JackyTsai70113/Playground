namespace playground.LeetCode._0000_0999;

public class _0162_FindPeakElement
{
    /// <summary>
    /// https://leetcode.com/problems/find-peak-element
    /// </summary>
    public static int FindPeakElement(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (m > 0 && nums[m - 1] > nums[m])
                r = m - 1;
            else if (nums[m] < nums[m + 1])
                l = m + 1;
            else
                return m;
        }
        return l;
    }
}
