namespace playground.Arrays;

public class MinimumSecondsClass
{
    /// <remarks>
    /// https://leetcode.com/problems/minimum-seconds-to-equalize-a-circular-array
    /// </remarks>
    public static int MinimumSeconds(IList<int> nums)
    {
        int n = nums.Count;
        Dictionary<int, List<int>> d = new();
        for (int i = 0; i < n; ++i)
        {
            if (!d.ContainsKey(nums[i]))
                d[nums[i]] = new();
            d[nums[i]].Add(i);
        }
        int res = int.MaxValue;
        foreach (var k in d.Keys)
        {
            if (d[k].Count == 1)
            {
                res = Math.Min(res, n / 2);
                continue;
            }
            int cur = int.MinValue;
            for (int i = 0; i < d[k].Count; ++i)
            {
                int distance = i == 0 ? d[k][0] + n - d[k][^1] : d[k][i] - d[k][i - 1];
                cur = Math.Max(cur, distance / 2);
            }
            res = Math.Min(res, cur);
        }
        return res;
    }
}
