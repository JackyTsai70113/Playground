namespace playground;

public class SearchRange0034
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array
    /// </summary>
    public static int[] SearchRange(int[] nums, int target)
    {
        var res = new int[] { -1, -1 };
        if (!nums.Any()) return res;
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] >= target)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        if (nums[l] != target)
        {
            return res;
        }
        res[0] = l;

        l = 0;
        r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (nums[m] <= target)
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }
        res[1] = l;
        return res;
    }
}
