namespace playground.LeetCode._2000_2999;

public class _2461_MaximumSubarraySum
{
    public static long MaximumSubarraySum(int[] nums, int k)
    {
        if (nums.Length < k)
            return 0;
        long res = 0, sum = 0;
        var set = new HashSet<int>();
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            while (set.Contains(nums[r]))
            {
                set.Remove(nums[l]);
                sum -= nums[l++];
            }
            set.Add(nums[r]);
            sum += nums[r];
            if (r - l + 1 == k)
            {
                res = Math.Max(res, sum);
                set.Remove(nums[l]);
                sum -= nums[l++];
            }
        }
        return res;
    }
}
