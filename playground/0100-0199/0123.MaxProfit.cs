namespace playground;

public class MaxProfit0123
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii
    /// </summary>
    /// <remarks>最多買賣 2 次(k <= 2)</remarks>
    public static int MaxProfit(int[] prices)
    {
        int buy1 = int.MinValue, buy2 = int.MinValue;
        int sell1 = 0, sell2 = 0;
        foreach (var p in prices)
        {
            buy1 = Math.Max(buy1, -p);
            sell1 = Math.Max(sell1, buy1 + p);
            buy2 = Math.Max(buy2, sell1 - p);
            sell2 = Math.Max(sell2, buy2 + p);
        }
        return sell2;
    }
}
