namespace playground.Arrays;

public class MaxSumClass
{
    public static int MaxSum(int[][] g)
    {
        int res = 0;
        int m = g.Length, n = g[0].Length;
        var dp = new int[m - 2, n - 2];
        dp[0, 0] += g[0][0];
        dp[0, 0] += g[0][1];
        dp[0, 0] += g[0][2];
        dp[0, 0] += g[1][1];
        dp[0, 0] += g[2][0];
        dp[0, 0] += g[2][1];
        dp[0, 0] += g[2][2];
        res = Math.Max(res, dp[0, 0]);
        for (int i = 0; i < m - 2; ++i)
        {
            for (int j = 0; j < n - 2; ++j)
            {
                if (i == 0 && j == 0) continue;
                if (i > 0)
                {
                    dp[i, j] = dp[i - 1, j];
                    dp[i, j] -= g[i - 1][j];
                    dp[i, j] -= g[i - 1][j + 1];
                    dp[i, j] -= g[i - 1][j + 2];
                    dp[i, j] -= g[i + 1][j];
                    dp[i, j] -= g[i + 1][j + 2];
                    dp[i, j] += g[i][j];
                    dp[i, j] += g[i][j + 2];
                    dp[i, j] += g[i + 2][j];
                    dp[i, j] += g[i + 2][j + 1];
                    dp[i, j] += g[i + 2][j + 2];
                }
                else
                {
                    dp[i, j] = dp[i, j - 1];
                    dp[i, j] -= g[i][j - 1];
                    dp[i, j] += g[i][j + 2];
                    dp[i, j] -= g[i + 1][j];
                    dp[i, j] += g[i + 1][j + 1];
                    dp[i, j] -= g[i + 2][j - 1];
                    dp[i, j] += g[i + 2][j + 2];
                }
                res = Math.Max(res, dp[i, j]);
            }
        }
        return res;
    }
}
