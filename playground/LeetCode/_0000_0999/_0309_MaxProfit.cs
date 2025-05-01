namespace playground.LeetCode._0000_0999;

public class _0309_MaxProfit
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown
    /// </summary>
    /// <remarks>買賣次數不限，賣完後隔天不能買</remarks>
    public static int MaxProfit(int[] prices)
    {
        int buy = int.MinValue, preSell = 0, sell = 0;
        foreach (var p in prices)
        {
            var temp = sell;
            (buy, sell) = (Math.Max(buy, preSell - p), Math.Max(sell, buy + p));
            preSell = temp;
        }
        return sell;
    }
}
