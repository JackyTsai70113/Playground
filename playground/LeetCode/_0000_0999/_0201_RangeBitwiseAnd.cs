namespace playground.LeetCode._0000_0999;

public class _0201_RangeBitwiseAnd
{
    /// <summary>
    /// https://leetcode.com/problems/bitwise-and-of-numbers-range
    /// </summary>
    public static int RangeBitwiseAnd(int left, int right)
    {
        while (right > left)
            right &= right - 1;
        return right & left;
    }
}
