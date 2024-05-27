namespace playground;

public class MinimumCost3108
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-walk-in-weighted-graph
    /// </summary>
    /// <remarks>
    /// DisjointSet
    /// </remarks>
    public static int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var ds = new DisjointSet(n);
        int[] costs = new int[n];
        Array.Fill(costs, int.MaxValue);
        foreach (var e in edges)
        {
            int g1 = ds.Find(e[0]), g2 = ds.Find(e[1]);
            if (g1 != g2)
            {
                ds.Union(e[0], e[1]);
                g1 = ds.Find(e[0]);
            }
            costs[g1] &= costs[g2] & e[2];
        }
        var res = new List<int>();
        foreach (var q in query)
        {
            int g1 = ds.Find(q[0]), g2 = ds.Find(q[1]);
            if (q[0] == q[1])
                res.Add(0);
            else if (g1 != g2)
                res.Add(-1);
            else
                res.Add(costs[g1]);
        }
        return res.ToArray();
    }

    /// <remarks>BFS</remarks>
    public static int[] MinimumCost2(int n, int[][] edges, int[][] query)
    {
        var g = new List<(int v, int cost)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }

        int[] groups = new int[n], costs = new int[n];
        HashSet<(int, int)> seen = new();
        Array.Fill(groups, -1);
        Array.Fill(costs, int.MaxValue);
        Queue<int> queue = new();
        for (int i = 0; i < n; i++)
        {
            if (groups[i] != -1)
                continue;
            queue.Enqueue(i);
            seen.Clear();
            while (queue.Count > 0)
            {
                foreach (var (v, cost) in g[queue.Dequeue()])
                {
                    if (seen.Contains((v, cost)))
                        continue;
                    seen.Add((v, cost));
                    groups[v] = i;
                    costs[i] &= cost;
                    queue.Enqueue(v);
                }
            }
            groups[i] = i;
        }
        var res = new List<int>();
        foreach (var q in query)
        {
            if (q[0] == q[1])
                res.Add(0);
            else if (groups[q[0]] != groups[q[1]])
                res.Add(-1);
            else
                res.Add(costs[groups[q[0]]]);
        }
        return res.ToArray();
    }
}
