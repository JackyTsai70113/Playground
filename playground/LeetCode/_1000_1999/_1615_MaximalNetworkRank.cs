namespace playground.LeetCode._1000_1999;

public class _1615_MaximalNetworkRank
{
    public static int MaximalNetworkRank(int n, int[][] roads)
    {
        var edges = new int[n, n];
        var degree = new int[n];
        foreach (var r in roads)
        {
            edges[r[0], r[1]] = 1;
            edges[r[1], r[0]] = 1;
            degree[r[0]]++;
            degree[r[1]]++;
        }
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                res = Math.Max(res, degree[i] + degree[j] - edges[i, j]);
            }
        }
        return res;
    }
}
