namespace playground.LeetCode._0000_0999;

public class _0268_MissingNumber
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number
    /// </summary>
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }
}
