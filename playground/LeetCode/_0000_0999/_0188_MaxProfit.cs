namespace playground.LeetCode._0000_0999;

public class _0188_MaxProfit
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv
    /// </summary>
    /// <remarks>買賣限制 k 次</remarks>
    public static int MaxProfit(int k, int[] prices)
    {
        int[] buy = new int[k + 1], sell = new int[k + 1];
        Array.Fill(buy, int.MinValue);
        foreach (var p in prices)
        {
            for (int i = 1; i <= k; i++)
            {
                buy[i] = Math.Max(buy[i], sell[i - 1] - p);
                sell[i] = Math.Max(sell[i], buy[i] + p);
            }
        }
        return sell[^1];
    }
}
