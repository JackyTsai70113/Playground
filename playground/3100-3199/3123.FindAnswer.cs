namespace playground;

public class FindAnswer3123
{
    /// <summary>
    /// https://leetcode.com/problems/find-edges-in-shortest-paths
    /// </summary>
    public static bool[] FindAnswer(int n, int[][] edges)
    {
        var g = new List<(int, int)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }
        var d0 = Dijkstra(0, g);
        var dn = Dijkstra(n - 1, g);
        var res = new List<bool>();
        foreach (var e in edges)
        {
            int u = e[0], v = e[1], d = e[2];
            // 0->u + d + v->n-1 == 0->n-1
            if (d0[u] + d + dn[v] == d0[n - 1])
                res.Add(true);
            // 0->v + d + u->n-1 == 0->n-1
            else if (d0[v] + d + dn[u] == d0[n - 1])
                res.Add(true);
            else
                res.Add(false);
        }
        return res.ToArray();
    }

    /// <summary>
    /// 取得 source 到各節點的最短路徑長
    /// </summary>
    /// <param name="source">開始的節點</param>
    /// <param name="g">weighted graph</param>
    /// <returns>從 <c>source</c> 到各節點的最短路徑長</returns>
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
                if (total + d < res[v])
                {
                    res[v] = total + d;
                    pq.Enqueue((v, res[v]), res[v]);
                }
            }
        }
        return res;
    }
}
