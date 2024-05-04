namespace playground;

public class Graph
{

    /// <summary>
    /// build undirected graph
    /// </summary>
    public static List<int>[] BuildUG(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        return g;
    }

    /// <summary>
    /// build undirected weighted graph
    /// </summary>
    public static List<(int v, int w)>[] BuildUWG(int n, int[][] edges)
    {
        var g = new List<(int n, int w)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }
        return g;
    }

    /// <summary>
    /// build directed weighted graph
    /// </summary>
    public static List<(int v, int w)>[] BuildDWG(int n, int[][] edges)
    {
        var g = new List<(int n, int w)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
            g[e[0]].Add((e[1], e[2]));
        return g;
    }

    /// <summary>
    /// 取得 source 到各節點的最短路徑長
    /// </summary>
    /// <param name="source">開始的節點</param>
    /// <param name="g">weighted graph</param>
    /// <returns>從 <c>source</c> 到各節點的最短路徑長</returns>
    public static int[] Dijkstra(int source, List<(int, int)>[] g)
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
            if (res[u] != total) continue;
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

    /// <summary>
    /// 取得任意兩節點的最短路徑長
    /// </summary>
    /// <param name="g">weighted graph</param>
    /// <returns>任意兩節點的最短路徑長</returns>
    public static int[,] Floyd(List<(int v, int w)>[] g)
    {
        int n = g.Length;
        var dist = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                dist[i, j] = int.MaxValue;
            foreach (var (v, w) in g[i])
                dist[i, v] = w;
            dist[i, i] = 0;
        }
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i == k || k == j) continue;
                    dist[i, j] = (int)Math.Min(dist[i, j], (long)dist[i, k] + dist[k, j]);
                }
        return dist;
    }
}
