namespace playground.LeetCode._2000_2999;

public class _2756_AlternatingSubarray
{
    /// <summary>
    /// https://leetcode.com/problems/longest-alternating-subarray/
    /// </summary>
    public static int AlternatingSubarray(int[] nums)
    {
        int n = nums.Length, res = -1;
        for (int l = 0; l < n - 1; l++)
        {
            if (nums[l + 1] - nums[l] != 1) continue;
            int r = l + 1;
            while (r < n - 1 && nums[r - 1] == nums[r + 1]) r++;
            res = Math.Max(res, r - l + 1);
            l = r - 1;
        }
        return res;
    }
}
