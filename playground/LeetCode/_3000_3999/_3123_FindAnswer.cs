namespace playground.LeetCode._3000_3999;

public class _3123_FindAnswer
{
    public static bool[] FindAnswer(int n, int[][] edges)
    {
        var g = Graph.BuildUWG(n, edges);
        var d0 = Graph.Dijkstra(0, g);
        var dn = Graph.Dijkstra(n - 1, g);
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
}
