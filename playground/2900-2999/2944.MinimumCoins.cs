namespace playground;

public class MinimumCoins_2944
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-coins-for-fruits
    /// </summary>
    public static int MinimumCoins(int[] A)
    {
        var dp = new int[A.Length];
        int dfs(int i)
        {
            if (i >= A.Length) return 0;
            if (dp[i] != 0) return dp[i];
            dp[i] = int.MaxValue;
            for (int j = i + 1; j <= 2 * i + 2; ++j)
                dp[i] = Math.Min(dp[i], dfs(j));
            return dp[i] += A[i];
        }
        return dfs(0);
    }
}
