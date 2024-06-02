namespace playground;

public class Search0033
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array
    /// </summary>
    public static int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] == target)
                return m;
            if (NeedToBeLeft(nums, target, m))
                r = m;
            else
                l = m + 1;
        }
        return -1;
    }

    static bool NeedToBeLeft(int[] nums, int target, int index)
    {
        if (nums[0] < nums[index])
        {
            return nums[0] <= target && target < nums[index];
        }
        else
        {
            return !(nums[index] < target && target <= nums[^1]);
        }
    }
}
