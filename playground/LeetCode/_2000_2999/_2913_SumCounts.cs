namespace playground.LeetCode._2000_2999;

public class _2913_SumCounts
{
    /// <summary>
    /// https://leetcode.com/problems/subarrays-distinct-element-sum-of-squares-i
    /// </summary>
    public static int SumCounts(IList<int> nums)
    {
        var res = 0;
        Dictionary<int, int> d;
        for (int i = 0; i < nums.Count; ++i)
        {
            d = new();
            for (int j = i; j < nums.Count; ++j)
            {
                d[nums[j]] = d.ContainsKey(nums[j]) ? d[nums[j]] + 1 : 1;
                res += d.Keys.Count * d.Keys.Count;
            }
        }
        return res;
    }
}
