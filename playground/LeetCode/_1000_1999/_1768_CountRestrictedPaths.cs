namespace playground.LeetCode._1000_1999;

public class _1768_CountRestrictedPaths
{
    public static int CountRestrictedPaths(int n, int[][] edges)
    {
        var g = new List<(int, int)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0] - 1].Add((e[1] - 1, e[2]));
            g[e[1] - 1].Add((e[0] - 1, e[2]));
        }
        var distanceToLastNode = new int[n];
        for (int i = 0; i < n; i++) distanceToLastNode[i] = int.MaxValue;
        distanceToLastNode[n - 1] = 0;
        var pq = new PriorityQueue<int, int>();
        var seen = new bool[n];
        pq.Enqueue(n - 1, distanceToLastNode[n - 1]);
        while (pq.Count > 0)
        {
            var u = pq.Dequeue();
            if (seen[u]) continue;
            seen[u] = true;
            foreach (var (v, d) in g[u])
            {
                if (distanceToLastNode[v] > distanceToLastNode[u] + d)
                {
                    distanceToLastNode[v] = distanceToLastNode[u] + d;
                    pq.Enqueue(v, distanceToLastNode[v]);
                }
            }
        }

        long[] count = new long[n];
        count[n - 1] = 1;
        long MOD = (long)1e9 + 7;
        var pq2 = new PriorityQueue<int, long>();
        for (int i = 0; i < n; i++) seen[i] = false;
        pq2.Enqueue(n - 1, count[n - 1]);
        while (pq2.Count > 0)
        {
            var u = pq2.Dequeue();
            if (seen[u]) continue;
            seen[u] = true;
            foreach (var (v, _) in g[u])
            {
                if (distanceToLastNode[v] > distanceToLastNode[u])
                {
                    count[v] = (count[v] + count[u]) % MOD;
                    pq2.Enqueue(v, distanceToLastNode[v]);
                }
            }
        }
        return (int)count[0];
    }
}
