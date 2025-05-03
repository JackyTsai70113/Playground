namespace playground.LeetCode._0000_0999;

public class _0441_ArrangeCoins
{
    /// <summary>
    /// https://leetcode.com/problems/arranging-coins
    /// </summary>
    public static int ArrangeCoins(int n)
    {
        long l = 1, r = int.MaxValue, nn = n;
        while (l < r)
        {
            long m = l + (r - l + 1) / 2;
            if (nn >= m * (m + 1) / 2)
                l = m;
            else
                r = m - 1;
        }
        return (int)l;
    }
}
