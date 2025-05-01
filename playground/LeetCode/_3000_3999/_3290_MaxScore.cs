namespace playground;

public class _3290_MaxScore
{
    public static long MaxScore(int[] a, int[] b)
    {
        long[,] dp = new long[4, b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                dp[j, i] = (long)a[j] * b[i];
            }
        }
        dp[1, 1] += dp[0, 0];
        dp[2, 2] += dp[1, 1];
        dp[3, 3] += dp[2, 2];
        for (int i = 1; i < b.Length; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                if (i + j == b.Length)
                    break;
                dp[j, i + j] = Math.Max(dp[j, i + j] + (j == 0 ? 0 : dp[j - 1, i + j - 1]), dp[j, i + j - 1]);
            }
        }
        return dp[3, b.Length - 1];
    }
}
