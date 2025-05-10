namespace playground.GeeksforGeeks;

public class _0945_Knapsack
{
    /// <summary>
    /// https://www.geeksforgeeks.org/problems/0-1-knapsack-problem0945/1
    /// </summary>
    /// <param name="W">Weight of knapsack</param>
    /// <param name="val">Value of items</param>
    /// <param name="wt">Weight of items</param>
    /// <returns>Maximum value that can be put in knapsack</returns>
    /// <remarks>
    /// 0/1 knapsack problem
    /// Time complexity: O(n * W), Space complexity: O(n * W)
    /// </remarks>
    public static int Knapsack(int W, int[] val, int[] wt)
    {
        int n = val.Length;
        var dp = new int[n + 1, W + 1];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= W; j++)
            {
                if (j < wt[i - 1])
                    dp[i, j] = dp[i - 1, j];
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - wt[i - 1]] + val[i - 1]);
            }
        }
        return dp[n, W];
    }


    /// <remarks>
    /// Time complexity: O(n * W), Space complexity: O(W)
    /// </remarks>
    public static int Knapsack_OptimizeSpace(int W, int[] val, int[] wt)
    {
        int n = val.Length;
        var dp = new int[W + 1];
        for (int i = 1; i <= n; i++)
        {
            for (int j = W; j >= wt[i - 1]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - wt[i - 1]] + val[i - 1]);
            }
        }
        return dp[W];
    }
}
