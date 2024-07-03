namespace playground;

public class MinimumDiameterAfterMerge3203
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-diameter-after-merging-two-trees
    /// </summary>
    public static int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
    {
        var (_, _, d1) = Diameter(edges1);
        var (_, _, d2) = Diameter(edges2);
        return Math.Max(Math.Max(d1, d2), (d1 + 1) / 2 + (d2 + 1) / 2 + 1);
    }

    public static (int node1, int node2, int diameter) Diameter(int[][] edges)
    {
        if (!edges.Any()) return (0, 0, 0);
        int n = edges.Length + 1;
        List<int>[] graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }
        var (v1, _) = Farthest(graph, 0);
        var (v2, d) = Farthest(graph, v1);
        return (v1, v2, d);
    }

    private static (int node, int distance) Farthest(List<int>[] graph, int i)
    {
        int n = graph.Length, node = -1, maxD = -1;
        var q = new Queue<int>();
        q.Enqueue(i);
        var seen = new int[n];
        seen[i] = 1;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var v in graph[u])
            {
                if (seen[v] != 0) continue;
                seen[v] = seen[u] + 1;
                q.Enqueue(v);
                if (seen[v] > maxD)
                {
                    maxD = seen[v];
                    node = v;
                }
            }
        }
        return (node, maxD - 1);
    }
}
