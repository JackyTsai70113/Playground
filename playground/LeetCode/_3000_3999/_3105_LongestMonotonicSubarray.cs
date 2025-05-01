namespace playground;

public class _3105_LongestMonotonicSubarray
{
    /// <summary>
    /// https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray
    /// </summary>
    public static int LongestMonotonicSubarray(int[] nums)
    {
        var res = 1;
        for (int l = 0, r = 1; r < nums.Length; r++)
        {
            if (nums[r - 1] >= nums[r])
                l = r;
            res = Math.Max(res, r - l + 1);
        }
        for (int l = 0, r = 1; r < nums.Length; r++)
        {
            if (nums[r - 1] <= nums[r])
                l = r;
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
