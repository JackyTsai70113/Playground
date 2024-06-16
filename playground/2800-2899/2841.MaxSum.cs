namespace playground;

public class MaxSum2841
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-almost-unique-subarray
    /// </summary>
    public static long MaxSum(IList<int> nums, int m, int k)
    {
        var d = new Dictionary<int, int>();
        int i = 0;
        long sum = 0, res = 0;
        for (; i < k; i++)
        {
            d[nums[i]] = d.ContainsKey(nums[i]) ? d[nums[i]] + 1 : 1;
            sum += nums[i];
        }
        if (d.Keys.Count >= m)
            res = Math.Max(res, sum);
        for (; i < nums.Count; i++)
        {
            d[nums[i]] = d.ContainsKey(nums[i]) ? d[nums[i]] + 1 : 1;
            if (--d[nums[i - k]] == 0)
                d.Remove(nums[i - k]);
            sum += nums[i] - nums[i - k];
            if (d.Keys.Count >= m)
                res = Math.Max(res, sum);
        }
        return res;
    }
}
