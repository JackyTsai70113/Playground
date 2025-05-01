namespace playground.LeetCode._0000_0999;

public class _0172_TrailingZeroes
{
    /// <summary>
    /// https://leetcode.com/problems/factorial-trailing-zeroes
    /// </summary>
    public static int TrailingZeroes(int n)
    {
        var res = 0;
        for (int i = 5; i <= 10000; i *= 5)
            res += n / i;
        return res;
    }
}
