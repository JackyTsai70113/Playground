# Knapsack Problem(背包問題)

## 0/1 Knapsack Problem

- 每項物品最多只能拿一個
  |                  | 0   | 1   | 2   | 3   | 4   | 5   |
  | ---------------- | --- | --- | --- | --- | --- | --- |
  | wi (weight of i) | 4   | 5   | 2   | 6   | 3   | 7   |
  | vi (value of i)  | 6   | 7   | 5   | 12  | 5   | 18  |
- 暴力解，每個物品決定拿與不拿，為O(n^2)
- 二維DP:
  - 用`dp[i,j]`決定前`i`項物品放入容量`j`的背包所能產生的最大價值
  - 每次處理到第`i`件時，有兩種選擇
    - 不放入第`i`件物品，價值與前一件商品相同。
      - `dp[i,j] = dp[i-1,j]`
    - 放入第`i`件物品，價值是前一件商品，重量`j-wi`的價值再加上新加入的價值。
      - `dp[i,j] = dp[i-1,j-wi]+vi`
  - 因此可得 
    ```csharp
    if (j - wi < 0)
        dp[i,j] = dp[i-1,j];
    else
        dp[i,j] = max(dp[i-1,j], dp[i-1,j-wi] + vi)
    ```

## unbounded knapsack problem(完全背包問題)

- 每項物品可以拿無限多個（但須是整數）

1. 找錢問題 Coin Change

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

## Multidimensional Knapsack Problem

- 背包體積（而不是只是負重有限）

## Multiple Choice Knapsack Problem

- 每一「類型」物品最多拿一個

## Fractional Knapsack Problem

- 物品可以只拿分數個（比如 0.5 個）
- 貪婪演算法範圍
- 計算每種物品「每單位重量的價值」，從單位重量價值最高者開始取，直到背包放滿
