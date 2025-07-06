namespace playground.DynamicProgramming;

public class MaxMovesClass
{
    /// <remarks>https://leetcode.com/problems/maximum-number-of-moves-in-a-grid</remarks>
    public static int MaxMoves(int[][] g)
    {
        int m = g.Length, n = g[0].Length, res = 0;
        var dp = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = -1;
            }
        }
        int dfs(int r, int c)
        {
            if (c == n - 1)
            {
                return 0;
            }
            if (dp[r, c] == -1)
            {
                dp[r, c] = 0;
                if (r - 1 >= 0 && g[r][c] < g[r - 1][c + 1])
                {
                    dp[r, c] = Math.Max(dp[r, c], 1 + dfs(r - 1, c + 1));
                }
                if (g[r][c] < g[r][c + 1])
                {
                    dp[r, c] = Math.Max(dp[r, c], 1 + dfs(r, c + 1));
                }
                if (r + 1 < m && g[r][c] < g[r + 1][c + 1])
                {
                    dp[r, c] = Math.Max(dp[r, c], 1 + dfs(r + 1, c + 1));
                }
            }
            return dp[r, c];
        }
        for (int i = 0; i < m; ++i)
        {
            res = Math.Max(res, dfs(i, 0));
        }
        return res;
    }
}
