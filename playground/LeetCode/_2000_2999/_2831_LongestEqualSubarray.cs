using System;

namespace playground.LeetCode._2000_2999;

public class _2831_LongestEqualSubarray
{
    public static int LongestEqualSubarray(IList<int> nums, int k)
    {
        var d = new Dictionary<int, int>();
        int maxf = 0;
        for (int l = 0, r = 0; r < nums.Count; r++)
        {
            d[nums[r]] = d.GetValueOrDefault(nums[r]) + 1;
            maxf = Math.Max(maxf, d[nums[r]]);
            while (r - l + 1 - maxf > k)
            {
                d[nums[l]]--;
                l++;
            }
        }
        return maxf;
    }
}
