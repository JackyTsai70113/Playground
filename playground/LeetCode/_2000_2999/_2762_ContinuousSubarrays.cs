namespace playground.LeetCode._2000_2999;

public class _2762_ContinuousSubarrays
{
    /// <summary>
    /// https://leetcode.com/problems/continuous-subarrays
    /// </summary>
    public static long ContinuousSubarrays(int[] nums)
    {
        long res = 0;
        Dictionary<int, int> d = new();
        for (int l = 0, r = 0; r < nums.Length; ++r)
        {
            d[nums[r]] = d.ContainsKey(nums[r]) ? d[nums[r]] + 1 : 1;
            while (l < r && d.Keys.Max() - d.Keys.Min() > 2)
            {
                d[nums[l]]--;
                if (d[nums[l]] == 0) d.Remove(nums[l]);
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
