namespace playground.BinarySearch;

public class SearchInRotatedSortedArrayClass
{
    /// <remarks>https://leetcode.com/problems/search-in-rotated-sorted-array</remarks>
    public static int SearchInRotatedSortedArray(int[] nums, int target)
    {
        int n = nums.Length;
        int l = 0, r = n - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] == target) return m;
            if (nums[m] > nums[n - 1])
            {
                if (nums[l] <= target && target < nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
            {
                if (nums[m] <= target && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }
        return -1;
    }
}
