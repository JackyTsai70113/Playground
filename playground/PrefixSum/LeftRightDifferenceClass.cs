namespace playground.PrefixSum;

public class LeftRightDifferenceClass
{
    /// <summary>
    /// https://leetcode.com/problems/left-and-right-sum-differences
    /// </summary>
    public static int[] LeftRightDifference(int[] nums)
    {
        int n = nums.Length;
        int[] leftsum = new int[n], rightsum = new int[n];
        for (int i = 1; i < n; ++i)
        {
            leftsum[i] = nums[i - 1] + leftsum[i - 1];
        }
        for (int i = n - 2; i >= 0; --i)
        {
            rightsum[i] = nums[i + 1] + rightsum[i + 1];
        }
        var res = new int[n];
        for (int i = 0; i < n; ++i)
        {
            res[i] = Math.Abs(leftsum[i] - rightsum[i]);
        }
        return res;
    }
}
