namespace playground.LeetCode._3000_3999;

public class _3418_MaximumAmount
{
    public static int MaximumAmount(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var dp = new int[m, n, 3];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    dp[i, j, k] = int.MinValue;
                }
            }
        }

        dp[0, 0, 2] = A[0][0];
        if (A[0][0] < 0)
        {
            dp[0, 0, 1] = 0;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (dp[i - 1, j, k] != int.MinValue)
                            dp[i, j, k] = dp[i - 1, j, k] + A[i][j];
                    }
                    if (A[i][j] < 0)
                    {
                        dp[i, j, 1] = Math.Max(dp[i, j, 1], dp[i - 1, j, 2]);
                        dp[i, j, 0] = Math.Max(dp[i, j, 0], dp[i - 1, j, 1]);
                    }
                }
                if (j > 0)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (dp[i, j - 1, k] != int.MinValue)
                            dp[i, j, k] = Math.Max(dp[i, j, k], dp[i, j - 1, k] + A[i][j]);
                    }
                    if (A[i][j] < 0)
                    {
                        dp[i, j, 1] = Math.Max(dp[i, j, 1], dp[i, j - 1, 2]);
                        dp[i, j, 0] = Math.Max(dp[i, j, 0], dp[i, j - 1, 1]);
                    }
                }
            }
        }
        return Math.Max(dp[m - 1, n - 1, 0], Math.Max(dp[m - 1, n - 1, 1], dp[m - 1, n - 1, 2]));
    }
}
