namespace playground.LeetCode._0000_0999;

public class _0069_MySqrt
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx
    /// </summary>
    public static int MySqrt(int x)
    {
        long l = 0, r = x;
        while (l < r)
        {
            long m = l + (r - l + 1) / 2;
            if (m * m <= x)
                l = m;
            else
                r = m - 1;
        }
        return (int)l;
    }
}
