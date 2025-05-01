namespace playground.LeetCode._2000_2999;

public class _2537_CountGood
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-good-subarrays
    /// </summary>
    public static long CountGood(int[] nums, int k)
    {
        long res = 0;
        var d = new Dictionary<int, int>();
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            d[nums[r]] = 1 + (d.ContainsKey(nums[r]) ? d[nums[r]] : 0);
            k -= d[nums[r]] - 1;
            while (k + d[nums[l]] - 1 <= 0)
            {
                d[nums[l]]--;
                k += d[nums[l]];
                l++;
            }
            if (k <= 0) res += l + 1;
        }
        return res;
    }
}
