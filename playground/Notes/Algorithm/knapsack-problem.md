# Knapsack Problem

## fra

## unbounded knapsack problem

## 找錢問題 Coin Change

- 是一種 unbounded knapsack problem, 每個物品可以拿無限多個，但須是整數

```csharp
public int CoinChange(int[] coins, int amount)
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
```