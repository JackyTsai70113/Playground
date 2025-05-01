namespace playground.LeetCode._0000_0999;

public class _0034_SearchRange
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array
    /// </summary>
    public static int[] SearchRange(int[] nums, int target)
    {
        int left = FirstGreaterValue(nums, 0, nums.Length, target);
        if (left == nums.Length || nums[left] != target)
            return new int[] { -1, -1 };
        int right = FirstGreaterValue(nums, left, nums.Length, target + 1);
        return new int[] { left, right - 1 };
    }

    private static int FirstGreaterValue(int[] nums, int l, int r, int target)
    {
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] >= target)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    /// <summary>
    /// find duplicated values count in sorted array
    /// </summary>
    public static int SearchCount(int[] nums, int l, int r, int target)
    {
        int left = FirstGreaterValue(nums, l, r, target);
        if (left == nums.Length || nums[left] != target)
            return 0;
        int right = FirstGreaterValue(nums, left, nums.Length, target + 1);
        return right - left;
    }

    public static int SearchCount2(int[] nums, int l, int r, int target)
    {
        if (l >= r) return 0;
        int m = l + (r - l) / 2;
        if (nums[m] == target)
            return 1 + SearchCount2(nums, l, m, target) + SearchCount2(nums, m + 1, r, target);
        if (nums[m] > target)
            return SearchCount2(nums, l, m, target);
        else
            return SearchCount2(nums, m + 1, r, target);
    }
}
