namespace playground.GeeksforGeeks;

public class DP_13_CutRod
{
    /// <summary>
    /// https://www.geeksforgeeks.org/problems/rod-cutting0840/1
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public static int CutRod_TopDown(int[] price)
    {
        int n = price.Length;
        var dp = new int[n + 1];
        dp[1] = price[0];
        int Helper(int len)
        {
            if (len == 0)
                return 0;
            if (dp[len] != 0)
                return dp[len];

            
            for (int i = 1; i <= len; i++)
            {
                dp[len] = Math.Max(dp[len], price[i - 1] + Helper(len - i));
            }
            return dp[len];
        }
        return Helper(n);
    }

    public static int CutRod_BottomUp(int[] price)
    {
        int n = price.Length;
        var dp = new int[n + 1];
        dp[1] = price[0];
        for (int len = 2; len <= n; len++)
        {
            for (int j = 1; j <= len; j++)
            {
                dp[len] = Math.Max(dp[len], price[j - 1] + dp[len - j]);
            }
        }
        return dp[n];
    }
}
