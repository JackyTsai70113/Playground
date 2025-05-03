namespace playground._3200_3299;

public class _3250_CountOfPairs
{
    public static int CountOfPairs(int[] nums)
    {
        int n = nums.Length;
        long res = 0, MOD = (long)1e9 + 7;
        long[,] dp = new long[n, 1001];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= 1000; j++)
            {
                dp[i, j] = -1;
            }
        }
        long Dfs(int i, int cur)
        {
            if (i == n - 1) return 1;
            if (dp[i, cur] != -1)
                return dp[i, cur];
            dp[i, cur] = 0;
            for (int j = Math.Max(cur, nums[i + 1] - nums[i] + cur); j <= nums[i + 1]; j++)
            {
                dp[i, cur] = (dp[i, cur] + Dfs(i + 1, j)) % MOD;
            }
            return dp[i, cur];
        }
        for (int i = 0; i <= nums[0]; i++)
        {
            res = (res + Dfs(0, i)) % MOD;
        }
        return (int)res;
    }
}
