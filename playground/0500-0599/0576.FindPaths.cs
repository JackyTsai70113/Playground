namespace playground;

public class FindPaths0576
{
    /// <summary>
    /// https://leetcode.com/problems/out-of-boundary-paths
    /// </summary>
    public static int FindPaths(int m, int n, int maxMove, int r, int c)
    {
        var memo = new int[m, n, maxMove + 1];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k <= maxMove; k++)
                    memo[i, j, k] = int.MinValue;
        int dp(int r, int c, int curMove)
        {
            if (curMove == 0)
                return 0;
            if (memo[r, c, curMove] == int.MinValue)
            {
                memo[r, c, curMove] = 0;
                int MOD = (int)1e9 + 7;
                memo[r, c, curMove] = (memo[r, c, curMove] + (r - 1 < 0 ? 1 : dp(r - 1, c, curMove - 1))) % MOD;
                memo[r, c, curMove] = (memo[r, c, curMove] + (r + 1 == m ? 1 : dp(r + 1, c, curMove - 1))) % MOD;
                memo[r, c, curMove] = (memo[r, c, curMove] + (c - 1 < 0 ? 1 : dp(r, c - 1, curMove - 1))) % MOD;
                memo[r, c, curMove] = (memo[r, c, curMove] + (c + 1 == n ? 1 : dp(r, c + 1, curMove - 1))) % MOD;
            }
            return memo[r, c, curMove];
        }
        return dp(r, c, maxMove);
    }
}
