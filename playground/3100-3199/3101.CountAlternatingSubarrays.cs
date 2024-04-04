namespace playground;

public class CountAlternatingSubarrays3101
{
    /// <summary>
    /// https://leetcode.com/problems/count-alternating-subarrays
    /// </summary>
    public static long CountAlternatingSubarrays(int[] nums)
    {
        long res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (r != 0 && nums[r - 1] == nums[r])
            {
                l = r;
            }
            res += r - l + 1;
        }
        return res;
    }
}
