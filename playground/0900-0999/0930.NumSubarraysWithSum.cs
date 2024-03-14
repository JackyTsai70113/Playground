namespace playground;

public class NumSubarraysWithSum0930
{
    /// <summary>
    /// https://leetcode.com/problems/binary-subarrays-with-sum
    /// </summary>
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        return AtMost(nums, goal) - AtMost(nums, goal - 1);
    }

    private int AtMost(int[] nums, int goal)
    {
        if (goal < 0) return 0;
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            goal -= nums[r];
            while (goal < 0)
                goal += nums[l++];
            res += r - l + 1;
        }
        return res;
    }
}
