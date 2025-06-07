namespace playground.LeetCode._1000_1999;

public class _1334_FindTheCity
{
    public static int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var g = Graph.BuildUWG(n, edges);
        var dist = Graph.Floyd(g);
        int res = 0, min = n;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
                if (dist[i, j] <= distanceThreshold)
                    count++;
            if (count <= min)
            {
                min = count;
                res = i;
            }
        }
        return res;
    }

    public static int FindTheCity2(int n, int[][] edges, int distanceThreshold)
    {
        var memo = new int[n, n];
        foreach (var e in edges)
            memo[e[0], e[1]] = memo[e[1], e[0]] = e[2];
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                {
                    if (i == j || i == k || k == j) continue;
                    memo[i, j] = memo[i, j] == 0 ? int.MaxValue : memo[i, j];
                    memo[i, k] = memo[i, k] == 0 ? int.MaxValue : memo[i, k];
                    memo[k, j] = memo[k, j] == 0 ? int.MaxValue : memo[k, j];
                    memo[i, j] = (int)Math.Min(memo[i, j], (long)memo[i, k] + memo[k, j]);
                    memo[j, i] = (int)Math.Min(memo[i, j], (long)memo[i, k] + memo[k, j]);
                }
        int res = 0, min = n;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
                if (memo[i, j] <= distanceThreshold)
                    count++;
            if (count <= min)
            {
                min = count;
                res = i;
            }
        }
        return res;
    }
}
