namespace playground.LeetCode._3000_3999;

public class _3604_MinTime
{
    public static int MinTime(int n, int[][] edges)
    {
        var g = new List<(int v, int s, int e)>[n];
        for (int i = 0; i < n; i++)
            g[i] = new();
        foreach (var e in edges)
            g[e[0]].Add((e[1], e[2], e[3]));

        var dist = new int[n];
        for (int i = 0; i < n; i++) dist[i] = int.MaxValue;
        dist[0] = 0;
        var pq = new PriorityQueue<(int u, int t), int>();
        pq.Enqueue((0, 0), 0);

        while (pq.Count > 0)
        {
            var (u, t) = pq.Dequeue();
            if (t > dist[u]) continue;
            if (u == n - 1) return t;
            foreach (var (v, s, e) in g[u])
            {
                int nextTime = Math.Max(t, s);
                if (nextTime <= e)
                {
                    nextTime += 1;
                    if (nextTime < dist[v])
                    {
                        dist[v] = nextTime;
                        pq.Enqueue((v, nextTime), nextTime);
                    }
                }
            }
        }
        return -1;
    }
}
