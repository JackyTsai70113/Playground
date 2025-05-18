namespace playground.LeetCode._0000_0999;

public class _0343_IntegerBreak
{
    public static int IntegerBreak_DP(int n)
    {
        var dp = new int[n + 1];
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j * 2 <= i; j++)
            {
                dp[i] = Math.Max(dp[i],
                    Math.Max(j, dp[j]) *
                    Math.Max(i - j, dp[i - j])
                );
            }
        }
        return dp[n];
    }

    public static int IntegerBreak_Math(int n)
    {
        if (n == 2) return 1;
        if (n == 3) return 2;
        if (n % 3 == 0) return (int)Math.Pow(3, n / 3);
        if (n % 3 == 1) return (int)Math.Pow(3, n / 3 - 1) * 4;
        return (int)Math.Pow(3, n / 3) * 2;
    }
}
