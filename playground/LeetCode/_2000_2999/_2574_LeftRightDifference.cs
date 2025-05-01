namespace playground.LeetCode._2000_2999;

public class _2574_LeftRightDifference
{
    /// <summary>
    /// https://leetcode.com/problems/left-and-right-sum-differences
    /// </summary>
    public static int[] LeftRightDifference(int[] nums)
    {
        int n = nums.Length, sum = nums.Sum();
        var res = new int[n];
        for (int i = 0, left = 0; i < n; i++)
        {
            var right = sum - nums[i] - left;
            res[i] = Math.Abs(left - right);
            left += nums[i];
        }
        return res;
    }
}
