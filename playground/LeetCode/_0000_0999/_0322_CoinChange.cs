namespace playground.LeetCode._0000_0999;

public class _0322_CoinChange
{
    public static int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
            return 0;
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        foreach (var coin in coins)
        {
            for (int i = coin; i <= amount; i++)
            {
                dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}