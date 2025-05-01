namespace playground.LeetCode._2000_2999;

public class _2401_LongestNiceSubarray
{
    public static int LongestNiceSubarray(int[] nums)
    {
        int res = 0, cur = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            while ((cur & nums[r]) != 0)
            {
                cur ^= nums[l];
                l++;
            }
            cur |= nums[r];

            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
