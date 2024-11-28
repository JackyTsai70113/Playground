namespace playground._0700_0799;

public class _0741_CherryPickup
{
    // Dp, memorization
    public static int CherryPickup(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int[,,] dp = new int[m, n, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    dp[i, j, k] = -2;
                }
            }
        }
        dp[0, 0, 0] = A[0][0];
        int Dp(int x1, int y1, int x2)
        {
            int y2 = x1 + y1 - x2;
            if (x1 < 0 || y1 < 0 || x2 < 0 || x2 > x1 + y1)
            {
                return -1;
            }
            if (dp[x1, y1, x2] != -2)
            {
                return dp[x1, y1, x2];
            }
            dp[x1, y1, x2] = -1;
            if (A[x1][y1] == -1 || A[x2][y2] == -1)
                return -1;
            dp[x1, y1, x2] = Math.Max(dp[x1, y1, x2], Dp(x1 - 1, y1, x2));
            dp[x1, y1, x2] = Math.Max(dp[x1, y1, x2], Dp(x1 - 1, y1, x2 - 1));
            dp[x1, y1, x2] = Math.Max(dp[x1, y1, x2], Dp(x1, y1 - 1, x2));
            dp[x1, y1, x2] = Math.Max(dp[x1, y1, x2], Dp(x1, y1 - 1, x2 - 1));
            if (dp[x1, y1, x2] >= 0)
            {
                if (x1 == x2 && y1 == y2)
                {
                    dp[x1, y1, x2] += A[x1][y1];
                }
                else
                {
                    dp[x1, y1, x2] += A[x1][y1] + A[x2][y2];
                }
            }
            return dp[x1, y1, x2];
        }

        return Dp(m - 1, n - 1, m - 1) == -1 ? 0 : Dp(m - 1, n - 1, m - 1);
    }
}
