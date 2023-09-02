namespace playground.SlidingWindow;

public class MaxSumClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-almost-unique-subarray
    /// </summary>
    public static long MaxSum(IList<int> nums, int m, int k)
    {
        var d = new Dictionary<int, int>();
        long sum = 0, res = 0;

        for (int i = 0; i < nums.Count; ++i)
        {
            sum += nums[i];
            d[nums[i]] = d.ContainsKey(nums[i]) ? d[nums[i]] + 1 : 1;
            if (i >= k)
            {
                sum -= nums[i - k];
                d[nums[i - k]]--;
                if (d[nums[i - k]] == 0)
                    d.Remove(nums[i - k]);
            }
            if (i >= k - 1)
            {
                if (d.Keys.Count >= m)
                {
                    res = Math.Max(res, sum);
                }
            }
        }
        return res;
    }
}
