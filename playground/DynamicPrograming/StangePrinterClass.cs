namespace playground.DynamicPrograming;

public class StangePrinterClass
{
    /// <remarks>https://leetcode.com/problems/strange-printer</remarks>
    public static int StrangePrinter(string s)
    {
        int n = s.Length;
        var dp = new int[n, n];
        int dfs(int i, int j)
        {
            if (i == j) return 1;
            if (dp[i, j] == 0)
            {
                dp[i, j] = int.MaxValue;
                for (int k = i; k < j; ++k)
                {
                    int a = dfs(i, k);
                    int b = dfs(k + 1, j);
                    dp[i, j] = Math.Min(dp[i, j], a + b - (s[i] == s[j] ? 1 : 0));
                }
            }
            return dp[i, j];
        }
        return dfs(0, n - 1);
    }
}
