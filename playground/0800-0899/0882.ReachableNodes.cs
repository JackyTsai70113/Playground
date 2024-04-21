namespace playground;

public class ReachableNodes0882
{
    /// <summary>
    /// https://leetcode.com/problems/reachable-nodes-in-subdivided-graph
    /// </summary>
    public static int ReachableNodes(int[][] edges, int maxMoves, int n)
    {
        var g = new List<(int, int)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }
        var d = Dijkstra(0, g);
        var res = d.Count(x => x <= maxMoves);
        foreach (var e in edges)
        {
            int left = Math.Max(0, maxMoves - d[e[0]]);
            int right = Math.Max(0, maxMoves - d[e[1]]);
            res += Math.Min(e[2], left + right);
        }
        return res;
    }

    private static int[] Dijkstra(int source, List<(int, int)>[] g)
    {
        int n = g.Length;
        var res = new int[n];
        Array.Fill(res, int.MaxValue);
        res[source] = 0;
        var pq = new PriorityQueue<(int u, int d), int>();
        pq.Enqueue((source, 0), 0);
        while (pq.Count > 0)
        {
            var (u, total) = pq.Dequeue();
            if (res[u] != total)
                continue;
            foreach (var (v, d) in g[u])
            {
                if (total + d + 1 < res[v])
                {
                    res[v] = total + d + 1;
                    pq.Enqueue((v, res[v]), res[v]);
                }
            }
        }
        return res;
    }
}
