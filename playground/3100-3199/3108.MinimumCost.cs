namespace playground;

public class MinimumCost3108
{
    public static int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var ds = new DisjointSet2(n);
        foreach (var e in edges)
        {
            ds.Union(e[0], e[1], e[2]);
        }
        var res = new int[query.Length];
        for (int i = 0; i < query.Length; i++)
        {
            int g1 = ds.Find(query[i][0]), g2 = ds.Find(query[i][1]);
            if (g1 != g2)
                res[i] = -1;
            else
                res[i] = ds.ands[g1];
        }
        return res;
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
            if (groups[q[0]] != groups[q[1]])
                res.Add(-1);
            else
                res.Add(costs[groups[q[0]]]);
        }
        return res.ToArray();
    }
}

public class DisjointSet2
{
    public int[] groups;
    public int[] ranks;
    public int[] ands;
    public DisjointSet2(int n)
    {
        groups = new int[n];
        for (int i = 0; i < n; i++)
            groups[i] = i;
        ranks = new int[n];
        Array.Fill(ranks, 1);
        ands = new int[n];
        Array.Fill(ands, int.MaxValue);
    }

    public int Find(int node)
    {
        groups[node] =
            groups[node] == node ?
            node :
            Find(groups[node]);
        return groups[node];
    }

    public bool Union(int n1, int n2, int w)
    {
        int g1 = Find(n1);
        int g2 = Find(n2);
        if (g1 > g2)
            (g1, g2) = (g2, g1);
        groups[g2] = g1;
        ands[g1] &= ands[g2] & w;
        return true;
    }
}