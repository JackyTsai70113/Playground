namespace playground.LeetCode._0000_0999;

public class _0122_MaxProfit
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
    /// </summary>
    /// <remarks>買賣次數不限(k = +Infinity)</remarks>
    public static int MaxProfit(int[] prices)
    {
        int buy = int.MinValue, sell = 0;
        foreach (var p in prices)
        {
            (sell, buy) = (Math.Max(sell, buy + p), Math.Max(buy, sell - p));
        }
        return sell;
    }
}
