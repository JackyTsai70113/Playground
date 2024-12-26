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

        var pq = new PriorityQueue<(int, long), long>();
        var dists = new long[n];
        var ways = new long[n];
        var seen = new bool[n];
        long MOD = (long)1e9 + 7;

        pq.Enqueue((0, 0), 0);
        Array.Fill(dists, long.MaxValue);
        dists[0] = 0;
        ways[0] = 1;

        while (pq.Count > 0)
        {
            var (u, ud) = pq.Dequeue();
            if (seen[u]) continue;
            seen[u] = true;
            foreach (var (v, vd) in g[u])
            {
                if (dists[v] > ud + vd)
                {
                    dists[v] = ud + vd;
                    ways[v] = ways[u];
                    pq.Enqueue((v, dists[v]), dists[v]);
                }
                else if (dists[v] == ud + vd)
                {
                    ways[v] = (ways[v] + ways[u]) % MOD;
                }
            }
        }
        return (int)ways[n - 1];
    }
}
