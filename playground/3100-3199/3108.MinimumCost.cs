namespace playground;

public class MinimumCost3108
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-walk-in-weighted-graph
    /// </summary>
    /// <remarks>
    /// UnionFind
    /// </remarks>
    public static int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var uf = new UnionFind(n);
        int[] costs = new int[n];
        Array.Fill(costs, int.MaxValue);
        foreach (var e in edges)
        {
            int g1 = uf.Find(e[0]), g2 = uf.Find(e[1]);
            if (g1 != g2)
            {
                uf.Union(e[0], e[1]);
                g1 = uf.Find(e[0]);
            }
            costs[g1] &= costs[g2] & e[2];
        }
        var res = new List<int>();
        foreach (var q in query)
        {
            int g1 = uf.Find(q[0]), g2 = uf.Find(q[1]);
            if (q[0] == q[1])
                res.Add(0);
            else if (g1 != g2)
                res.Add(-1);
            else
                res.Add(costs[g1]);
        }
        return res.ToArray();
    }

    public class UnionFind
    {
        private readonly int[] groups;
        private readonly int[] ranks;
        public UnionFind(int n)
        {
            groups = new int[n];
            Array.Fill(groups, -1);
            ranks = new int[n];
            Array.Fill(ranks, 1);
        }

        public int Find(int node)
        {
            return groups[node] < 0 ? node : Find(groups[node]);
        }

        public void Union(int node1, int node2)
        {
            int g1 = Find(node1), g2 = Find(node2);
            if (g1 == g2) return;
            if (ranks[g2] > ranks[g1])
                (g1, g2) = (g2, g1);
            groups[g2] = g1;
            ranks[g1] += ranks[g2];
        }
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
