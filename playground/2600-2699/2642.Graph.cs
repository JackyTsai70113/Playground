namespace playground;

/// <summary>
/// https://leetcode.com/problems/design-graph-with-shortest-path-calculator
/// </summary>
public class Graph_2642
{
    readonly int n;
    readonly List<(int v, int cost)>[] graph;
    public Graph_2642() { }
    public Graph_2642(int n, int[][] edges)
    {
        this.n = n;
        graph = new List<(int, int)>[n];
        for (int i = 0; i < n; ++i)
            graph[i] = new();
        foreach (var e in edges)
            AddEdge(e);
    }

    public void AddEdge(int[] e)
    {
        graph[e[0]].Add((e[1], e[2]));
    }

    public int ShortestPath(int node1, int node2)
    {
        var costs = new int[n];
        Array.Fill(costs, int.MaxValue);
        costs[node1] = 0;
        var pq = new PriorityQueue<int, int>();
        var seen = new HashSet<int>();
        pq.Enqueue(node1, 0);
        seen.Add(node1);
        while (pq.Count > 0)
        {
            var node = pq.Dequeue();
            if (node == node2) return costs[node];
            foreach (var (v, edgeCost) in graph[node])
            {
                if (!seen.Contains(v))
                {
                    if (costs[node] + edgeCost < costs[v])
                    {
                        costs[v] = costs[node] + edgeCost;
                        pq.Enqueue(v, costs[v]);
                    }
                }
            }
        }
        return -1;
    }
}
