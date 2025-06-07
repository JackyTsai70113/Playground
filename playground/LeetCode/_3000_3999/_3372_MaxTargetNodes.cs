namespace playground.LeetCode._3000_3999;

public class _3372_MaxTargetNodes
{
    public static int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        int n = edges1.Length + 1;
        int m = edges2.Length + 1;
        var g1 = ToGraph(n, edges1);
        var g2 = ToGraph(m, edges2);

        static int dfs(int par, int u, List<int>[] g, int k)
        {
            if (k < 0) return 0;
            if (k == 0) return 1;
            int res = 1;
            foreach (var v in g[u])
            {
                if (v != par)
                {
                    res += dfs(u, v, g, k - 1);
                }
            }
            return res;
        }

        int max = Enumerable.Range(0, m)
            .Select(x => dfs(-1, x, g2, k - 1))
            .Max();
        var res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[i] = dfs(-1, i, g1, k) + max;
        }
        return res;
    }

    static List<int>[] ToGraph(int n, int[][] edges)
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
}
