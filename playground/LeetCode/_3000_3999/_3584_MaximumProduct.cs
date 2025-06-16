namespace playground.LeetCode._3000_3999;

public class _3584_MaximumProduct
{
    public static long MaximumProduct(int[] nums, int m)
    {
        var sd = new SortedDictionary<long, int>();
        for (int i = m - 1; i < nums.Length; i++)
        {
            sd[nums[i]] = sd.GetValueOrDefault(nums[i]) + 1;
        }

        long min = nums[0], max = nums[0], res = long.MinValue;
        for (int i = m - 1; i < nums.Length; i++)
        {
            min = Math.Min(min, nums[i - m + 1]);
            max = Math.Max(max, nums[i - m + 1]);

            res = Math.Max(res, max * nums[i]);
            res = Math.Max(res, min * nums[i]);
        }
        return res;
    }
}
