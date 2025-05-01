namespace playground.LeetCode._2000_2999;

public class _2973_PlacedCoins
{
    // https://leetcode.com/problems/find-number-of-coins-to-place-in-tree-nodes
    public static long[] PlacedCoins(int[][] edges, int[] cost)
    {
        var g = new List<int>[edges.Length + 1];
        for (int i = 0; i < g.Length; ++i)
        {
            g[i] = new List<int>();
        }
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        var res = new long[g.Length];
        List<int> dfs(int pa, int u)
        {
            var costs = new List<int> { cost[u] };
            foreach (var v in g[u])
            {
                if (v != pa)
                    costs.AddRange(dfs(u, v));
            }
            costs.Sort();
            if (costs.Count < 3)
            {
                res[u] = 1;
            }
            else
            {
                res[u] = Math.Max(res[u], (long)costs[0] * costs[1] * costs[^1]);
                res[u] = Math.Max(res[u], (long)costs[^1] * costs[^2] * costs[^3]);
            }
            if (costs.Count <= 5) return costs;
            else return new List<int> { costs[0], costs[1], costs[^3], costs[^2], costs[^1] };
        }
        dfs(-1, 0);
        return res;
    }
}
