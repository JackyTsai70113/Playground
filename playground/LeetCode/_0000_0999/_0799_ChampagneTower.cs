namespace playground.LeetCode._0000_0999;

public class _0799_ChampagneTower
{
    public static double ChampagneTower(int poured, int query_row, int query_glass)
    {
        var dp = new double[query_row + 1, query_row + 1];
        dp[0, 0] = poured;
        for (int i = 0; i < query_row; ++i)
        {
            for (int j = 0; j <= i; ++j)
            {
                var remain = Math.Max(0, dp[i, j] - 1);
                dp[i + 1, j] += remain / 2;
                dp[i + 1, j + 1] += remain / 2;
            }
        }
        return Math.Min(1, dp[query_row, query_glass]);
    }
}
