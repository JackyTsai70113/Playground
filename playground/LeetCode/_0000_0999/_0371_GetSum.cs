namespace playground.LeetCode._0000_0999;

public class _0371_GetSum
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-two-integers
    /// </summary>
    public static int GetSum(int a, int b)
    {
        while (b != 0)
        {
            var cur = a ^ b;
            b = (a & b) << 1;
            a = cur;
        }
        return a;
    }
}
