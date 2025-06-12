namespace playground.LeetCode._1000_1999;

public class _1594_MaxProductPath
{
    public static int MaxProductPath(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int MOD = (int)1e9 + 7;

        var min_memo = new long[n];
        var max_memo = new long[n];

        min_memo[0] = max_memo[0] = A[0][0];
        for (int j = 1; j < n; j++)
            min_memo[j] = max_memo[j] = min_memo[j - 1] * A[0][j];
        for (int i = 1; i < m; i++)
        {
            var min_memo2 = new long[n];
            var max_memo2 = new long[n];
            min_memo2[0] = max_memo2[0] = min_memo[0] * A[i][0];
            for (int j = 1; j < n; j++)
            {
                long a = max_memo[j] * A[i][j];
                long b = min_memo[j] * A[i][j];
                long c = max_memo2[j - 1] * A[i][j];
                long d = min_memo2[j - 1] * A[i][j];

                min_memo2[j] = Math.Min(Math.Min(a, b), Math.Min(c, d));
                max_memo2[j] = Math.Max(Math.Max(a, b), Math.Max(c, d));
            }
            min_memo = min_memo2;
            max_memo = max_memo2;
        }

        return max_memo[n - 1] < 0 ? -1 : (int)(max_memo[n - 1] % MOD);
    }
}
