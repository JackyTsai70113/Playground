namespace playground._1900_1999;

public class _1976_CountPaths
{
    public static int CountPaths(int n, int[][] roads)
    {
        if (n == 1) return 1;
        var g = new List<(int v, long d)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var r in roads)
        {
            g[r[0]].Add((r[1], r[2]));
            g[r[1]].Add((r[0], r[2]));
        }

        var dists = new (long d, long count)[n];
        dists[0] = (0, 1);
        for (int i = 1; i < n; i++)
        {
            dists[i] = (long.MaxValue, 0);
        }

        var pq = new PriorityQueue<int, long>();
        pq.Enqueue(0, dists[0].d);
        long MOD = (long)1e9 + 7;
        while (pq.Count > 0)
        {
            var u = pq.Dequeue();
            if (u == n - 1)
            {
                continue;
            }
            foreach (var (v, d) in g[u])
            {
                if (dists[v].d > dists[u].d + d)
                {
                    dists[v] = (dists[u].d + d, 1);
                    pq.Enqueue(v, dists[v].d);
                }
                else if (dists[v].d == dists[u].d + d)
                {
                    dists[v] = (dists[v].d, dists[v].count + 1);
                }
            }
        }
        return (int)(dists[n - 1].count % MOD);
    }
}
