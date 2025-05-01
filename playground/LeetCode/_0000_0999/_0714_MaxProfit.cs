namespace playground.LeetCode._0000_0999;

public class _0714_MaxProfit
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee
    /// </summary>
    public static int MaxProfit(int[] prices, int fee)
    {
        int buy = int.MinValue, sell = 0;
        foreach (var p in prices)
        {
            (sell, buy) = (Math.Max(sell, buy + p), Math.Max(buy, sell - p - fee));
        }
        return sell;
    }
}
