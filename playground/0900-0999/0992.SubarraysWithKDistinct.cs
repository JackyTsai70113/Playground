namespace playground;

public class SubarraysWithKDistinct0992
{
    /// <summary>
    /// https://leetcode.com/problems/subarrays-with-k-different-integers
    /// </summary>
    public static int SubarraysWithKDistinct(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        var res = 0;
        var d = new Dictionary<int, int>();
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            d[nums[r]] = 1 + (d.ContainsKey(nums[r]) ? d[nums[r]] : 0);
            if (d[nums[r]] == 1) k--;
            while (k < 0)
            {
                d[nums[l]]--;
                if (d[nums[l++]] == 0) k++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
