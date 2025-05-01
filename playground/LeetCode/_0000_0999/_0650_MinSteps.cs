namespace playground.LeetCode._0000_0999;

public class _0650_MinSteps
{
    public static int MinSteps(int n)
    {
        var dp = new int[n + 1];
        for (int i = 2; i < n + 1; i++)
        {
            dp[i] = i;
            for (int j = i - 1; j >= 2; j--)
            {
                if (i % j == 0)
                {
                    dp[i] = dp[j] + i / j;
                    break;
                }
            }
        }
        return dp[n];
    }

    public static int MinSteps2(int n)
    {
        int res = 0, factor = 2;
        while (n > 1)
        {
            while (n % factor == 0)
            {
                res += factor;
                n /= factor;
            }
            factor++;
        }
        return res;
    }
}