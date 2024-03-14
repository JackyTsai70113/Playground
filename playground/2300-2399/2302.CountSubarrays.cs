namespace playground;

public class CountSubarrays2302
{
    /// <summary>
    /// https://leetcode.com/problems/count-subarrays-with-score-less-than-k
    /// </summary>
    public static long CountSubarrays(int[] nums, long k)
    {
        long res = 0, sum = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            while (sum * (r - l + 1) >= k)
            {
                sum -= nums[l++];
            }
            res += r - l + 1;
        }
        return res;
    }
}
