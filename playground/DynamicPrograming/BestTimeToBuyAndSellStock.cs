namespace playground.DynamicPrograming;

public class BestTimeToBuyAndSellStock
{
    /*
        1. T[i][k]: 第 i 天後，最多 k 次交易的最大收益
        2. 每天有三件事可以做: 買，賣，休息
        3. 不能連續買，連續賣

        因此 T[i][k] 可以再分為 T[i][k][0], T[i][k][1]
        設定:
            T[i][k][0]: 第 i 天後，最多 k 次交易的最大收益，0 持股
            T[i][k][1]: 第 i 天後，最多 k 次交易的最大收益，1 持股
        初始值:
            T[-1][k][0] = 0 // 第 0 天開始前(第 -1 天後)，0 持股，收益為 0
            T[i][0][0] = 0  // 任一天後，0 次交易，0 持股，收益為 0
            T[-1][k][1] = -Infinity // 第 0 天開始前(第 -1 天後)，1 持股，不可能
            T[i][0][1] = -Infinity  // 任一天後，0 次交易，1 持股，不可能
        Subproblems:
            // 買賣加起來算一次交易所以賣不用加
            T[i][k][0] = max(T[i][k][0], T[i-1][k] + prices[i])
            // 多買一次 k 要多加一次
            T[i][k][1] = max(T[i][k][0], T[i-1][k-1] - prices[i])
    */

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    /// </summary>
    /// <remarks>只能買賣一次(k = 1)</remarks>
    public static int MaxProfit(int[] prices)
    {
        int T10 = 0, T11 = int.MinValue;
        foreach (var p in prices)
        {
            T10 = Math.Max(T10, T11 + p);
            T11 = Math.Max(T11, -p);
        }
        return T10;
    }

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
    /// </summary>
    /// <remarks>買賣次數不限(k = +Infinity)</remarks>
    public static int MaxProfitII(int[] prices)
    {
        int Tk0 = 0, Tk1 = int.MinValue;
        foreach (var p in prices)
        {
            var Tk0_old = Tk0;
            Tk0 = Math.Max(Tk0, Tk1 + p);
            Tk1 = Math.Max(Tk1, Tk0_old - p);
        }
        return Tk0;
    }

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii
    /// </summary>
    /// <remarks>最多買賣 2 次(k <= 2)</remarks>
    public static int MaxProfitIII(int[] prices)
    {
        int T10 = 0, T11 = int.MinValue;
        int T20 = 0, T21 = int.MinValue;
        foreach (var p in prices)
        {
            T20 = Math.Max(T20, T21 + p);
            T21 = Math.Max(T21, T10 - p);
            T10 = Math.Max(T10, T11 + p);
            T11 = Math.Max(T11, -p);
        }
        return Math.Max(T20, T10);
    }

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/#/description
    /// </summary>
    /// <remarks>買賣限制 k 次</remarks>
    public static int MaxProfitIV(int k, int[] prices)
    {
        if (k >= prices.Length / 2)
        {
            int Tk0 = 0, Tk1 = int.MinValue;
            foreach (var p in prices)
            {
                var Tk0_old = Tk0;
                Tk0 = Math.Max(Tk0, Tk1 + p);
                Tk1 = Math.Max(Tk1, Tk0_old - p);
            }
            return Tk0;
        }
        int[] memok0 = new int[k + 1];
        int[] memok1 = new int[k + 1];
        Array.Fill(memok1, int.MinValue);

        foreach (var p in prices)
        {
            for (int j = k; j > 0; j--)
            {
                memok0[j] = Math.Max(memok0[j], memok1[j] + p);
                memok1[j] = Math.Max(memok1[j], memok0[j - 1] - p);
            }
        }
        return memok0[k];
    }

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown
    /// </summary>
    /// <remarks>買賣次數不限，賣完後隔天不能買</remarks>
    public static int MaxProfitCoolDown(int[] prices)
    {
        int Tk0_pre = 0, Tk0 = 0, Tk1 = int.MinValue;
        foreach (var p in prices)
        {
            var Tk0_old = Tk0;
            Tk0 = Math.Max(Tk0, Tk1 + p);
            Tk1 = Math.Max(Tk1, Tk0_pre - p);
            Tk0_pre = Tk0_old;
        }
        return Tk0;
    }

    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee
    /// </summary>
    public static int MaxProfitWithFee(int[] prices, int fee)
    {
        int T_ik0 = 0, T_ik1 = int.MinValue;
        foreach (var price in prices)
        {
            int T_ik0_old = T_ik0;
            T_ik0 = Math.Max(T_ik0, T_ik1 + price);
            T_ik1 = Math.Max(T_ik1, T_ik0_old - price - fee);
        }
        return T_ik0;
    }
}
