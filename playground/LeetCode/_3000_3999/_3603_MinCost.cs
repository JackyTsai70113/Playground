namespace playground.LeetCode._3000_3999;

public class _3603_MinCost
{
    public static long MinCost(int m, int n, int[][] waitCost)
    {
        long[,] dp = new long[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                dp[i, j] = long.MaxValue;
        dp[0, 0] = 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                long currentEntryCost = GetEntryCost(i, j);

                if (i == 0 && j == 0)
                {
                    continue;
                }

                long costFromUp = long.MaxValue;
                long costFromLeft = long.MaxValue;

                if (i > 0)
                {
                    if (dp[i - 1, j] != long.MaxValue)
                    {
                        costFromUp = dp[i - 1, j];
                        if (ShouldPayWaitCost(i - 1, j, m, n))
                        {
                            costFromUp += waitCost[i - 1][j];
                        }
                        costFromUp += currentEntryCost;
                    }
                }

                if (j > 0)
                {
                    if (dp[i, j - 1] != long.MaxValue)
                    {
                        costFromLeft = dp[i, j - 1];
                        if (ShouldPayWaitCost(i, j - 1, m, n))
                        {
                            costFromLeft += waitCost[i][j - 1];
                        }
                        costFromLeft += currentEntryCost;
                    }
                }

                dp[i, j] = Math.Min(costFromUp, costFromLeft);
            }
        }

        return dp[m - 1, n - 1];
    }

    private static long GetEntryCost(int r, int c)
    {
        return (long)(r + 1) * (c + 1);
    }

    private static bool ShouldPayWaitCost(int r, int c, int m, int n)
    {
        return !((r == 0 && c == 0) || (r == m - 1 && c == n - 1));
    }
}
