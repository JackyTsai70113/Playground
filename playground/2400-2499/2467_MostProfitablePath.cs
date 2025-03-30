namespace playground._2400_2499;

public class _2467_MostProfitablePath
{
    public static int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        int n = edges.Length + 1;
        var g = new List<int>[n];
        for (int i = 0; i < n; i++)
            g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        int[] pars = new int[n], depth = new int[n];
        void dfs(int par, int u, int d)
        {
            pars[u] = par;
            depth[u] = d;
            foreach (var v in g[u])
            {
                if (v != par)
                {
                    dfs(u, v, d + 1);
                }
            }
        }
        dfs(-1, 0, 0);

        int originalBob = bob;
        for (int i = depth[originalBob]; i > depth[originalBob] / 2; i--)
        {
            amount[bob] = 0;
            bob = pars[bob];
        }
        if (depth[originalBob] % 2 == 0)
        {
            amount[bob] /= 2;
        }

        int dfs2(int par, int u)
        {
            int res = amount[u];
            int max = int.MinValue;
            foreach (var v in g[u])
            {
                if (v != par)
                {
                    max = Math.Max(max, dfs2(u, v));
                }
            }
            if (max != int.MinValue)
                res += max;
            return res;
        }
        return dfs2(-1, 0);
    }
}
