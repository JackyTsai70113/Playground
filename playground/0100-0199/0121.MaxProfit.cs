namespace playground;

public class MaxProfit0121
{
    /*
        1. T[i][k]: 第 i 天後，最多 k 次交易的最大收益
        2. 每天有三件事可以做: 買，賣，休息
        3. 不能連續買，連續賣

        - 因此 T[i][k] 可以再分為 T[i][k][0], T[i][k][1]
        - 設定:
            T[i][k][0]: 第 i 天後，最多 k 次交易的最大收益，0 持股
            T[i][k][1]: 第 i 天後，最多 k 次交易的最大收益，1 持股
        - 初始值:
            T[-1][k][0] = 0 // 第 0 天開始前(第 -1 天後)，0 持股，收益為 0
            T[i][0][0] = 0  // 任一天後，0 次交易，0 持股，收益為 0
            T[-1][k][1] = -Infinity // 第 0 天開始前(第 -1 天後)，1 持股，不可能
            T[i][0][1] = -Infinity  // 任一天後，0 次交易，1 持股，不可能
        - Subproblems:
            // 買賣加起來算一次交易所以賣不用加
            T[i][k][0] = max(T[i][k][0], T[i-1][k] + prices[i])
            // 多買一次 k 要多加一次
            T[i][k][1] = max(T[i][k][0], T[i-1][k-1] - prices[i])
        - Practice
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown
            - https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee
    */

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    /// </summary>
    /// <remarks>只能買賣一次(k = 1)</remarks>
    public static int MaxProfit(int[] prices)
    {
        int buy = int.MinValue, sell = 0;
        foreach (var p in prices)
        {
            sell = Math.Max(sell, buy + p);
            buy = Math.Max(buy, -p);
        }
        return sell;
    }
}
