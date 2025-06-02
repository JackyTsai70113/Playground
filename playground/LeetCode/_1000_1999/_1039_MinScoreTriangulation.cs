namespace playground.LeetCode._1000_1999;

public class _1039_MinScoreTriangulation
{
    public static int MinScoreTriangulation_BU(int[] A)
    {
        int n = A.Length;
        var dp = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 2; j < n; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }
        for (int len = 2; len <= n - 1; len++)
        {
            for (int l = 0; l + len < n; l++)
            {
                int r = l + len;
                for (int i = l + 1; i < r; i++)
                {
                    dp[l, r] = Math.Min(dp[l, r], A[l] * A[r] * A[i] + dp[l, i] + dp[i, r]);
                }
            }
        }
        return dp[0, n - 1];
    }

    public static int MinScoreTriangulation_TD(int[] A)
    {
        int n = A.Length;
        var dp = new int[n, n];
        int dfs(int l, int r)
        {
            if (l + 1 == r) return 0;
            if (dp[l, r] != 0) return dp[l, r];
            int res = int.MaxValue;
            for (int i = l + 1; i <= r - 1; i++)
            {
                res = Math.Min(res, A[l] * A[i] * A[r] + dfs(l, i) + dfs(i, r));
            }
            // Console.WriteLine(l+" "+r+ " " + res);
            return dp[l, r] = res;
        }
        return dfs(0, n - 1);
    }
}
