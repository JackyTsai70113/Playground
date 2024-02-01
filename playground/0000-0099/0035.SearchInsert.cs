namespace playground;

public class SearchInsert0035
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position
    /// </summary>
    public static int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length;
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
}
