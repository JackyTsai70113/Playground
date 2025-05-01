namespace playground.LeetCode._0000_0999;

public class _0136_SingleNumber
{
    /// <summary>
    /// https://leetcode.com/problems/single-number
    /// </summary>
    public static int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (var num in nums)
            res ^= num;
        return res;
    }
}
