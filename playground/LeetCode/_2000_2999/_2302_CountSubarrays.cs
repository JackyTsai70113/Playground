namespace playground.LeetCode._2000_2999;

public class _2302_CountSubarrays
{
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
