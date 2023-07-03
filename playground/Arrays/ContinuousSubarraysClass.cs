namespace playground.Arrays;

public class ContinuousSubarraysClass
{
    /// <summary>
    /// https://leetcode.com/problems/continuous-subarrays
    /// </summary>
    public static long ContinuousSubarrays(int[] nums)
    {
        long res = 0;
        Dictionary<int, int> sd = new();
        for (int i = 0, l = 0; i < nums.Length; ++i)
        {
            sd[nums[i]] = sd.TryGetValue(nums[i], out var v) ? v + 1 : 1;
            while (l < i && sd.Keys.Max() - sd.Keys.Min() > 2)
            {
                sd[nums[l]]--;
                if (sd[nums[l]] == 0)
                    sd.Remove(nums[l]);
                l++;
            }
            res += i - l + 1;
        }
        return res;
    }
}
