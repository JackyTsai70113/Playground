namespace playground.LeetCode._0000_0999;

public class _0518_Change
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change-ii/
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="coins"></param>
    /// <returns></returns>
    /// <remarks>
    /// unbounded knapsack problem
    /// Time complexity: O(n * amount), Space complexity: O(n * amount)
    /// </remarks>
    public static int Change(int amount, int[] coins)
    {
        var dp = new int[coins.Length + 1, amount + 1];
        for (int i = 0; i <= coins.Length; i++)
        {
            dp[i, 0] = 1;
        }
        for (int i = 1; i <= coins.Length; i++)
        {
            for (int j = 1; j <= amount; j++)
            {
                if (j - coins[i - 1] < 0)
                    dp[i, j] = dp[i - 1, j];
                else
                    dp[i, j] = dp[i - 1, j] + dp[i, j - coins[i - 1]];
            }
        }
        return dp[coins.Length, amount];
    }

    /// <remarks>
    /// unbounded knapsack problem
    /// Time complexity: O(n * amount), Space complexity: O(amount)
    /// </remarks>
    public static int Change_OptimizeSpace(int amount, int[] coins)
    {
        var dp = new int[amount + 1];
        dp[0] = 1;
        for (int i = 1; i <= coins.Length; i++)
        {
            for (int j = coins[i - 1]; j <= amount; j++)
            {
                dp[j] += dp[j - coins[i - 1]];
            }
        }
        return dp[amount];
    }
}
