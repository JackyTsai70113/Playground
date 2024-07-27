
namespace playground;

public class Solution
{
    public long MaximumScore(int[][] A)
    {
        if (A.Length == 1) return A[0][1];
        int n = A.Length;
        var dp = new long[n, n, 2];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j, 0] =
                    Math.Max((i == 0 ? 0 : dp[i - 1, j, 0]) +
                        (j == 0 ? 0 : dp[i, j - 1, 1]) -
                        (i == 0 || j == 0 ? 0 : dp[i - 1, j - 1, 1]),
                        (i == 0 ? 0 : dp[i - 1, j, 0]) +
                        (j == 0 ? 0 : dp[i, j - 1, 0]) -
                        (i == 0 || j == 0 ? 0 : dp[i - 1, j - 1, 0]));
                dp[i, j, 1] =
                    A[i][j] +
                    Math.Max(i == 0 ? 0 : dp[i - 1, j, 0], i == 0 ? 0 : dp[i - 1, j, 1]) +
                        (j == 0 ? 0 : dp[i, j - 1, 0]) -
                        (i == 0 || j == 0 ? 0 : dp[i - 1, j - 1, 0]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(dp[i, j, 0] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(dp[i, j, 1] + " ");
            }
            Console.WriteLine();
        }
        return Math.Max(dp[n - 1, n - 1, 0], dp[n - 1, n - 1, 1]);
    }
}