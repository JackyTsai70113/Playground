namespace playground;

public class CoinChange0322
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change
    /// </summary>
    public static int CoinChange(int[] coins, int amount)
    {
        if (amount == 0) return 0;
        var memo = new int[amount + 1];
        Array.Fill(memo, amount + 1);
        memo[0] = 0;
        foreach (var coin in coins)
        {
            for (int i = coin; i <= amount; i++)
            {
                memo[i] = Math.Min(memo[i], memo[i - coin] + 1);
            }
        }
        return memo[amount] > amount ? -1 : memo[amount];
    }
}