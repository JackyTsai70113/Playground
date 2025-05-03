namespace playground;

public class _3249_CountGoodNodes
{
    public static int CountGoodNodes(int[][] edges)
    {
        int n = edges.Length + 1;
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        int goodNodesCount = 0;
        int Dfs(int par, int u)
        {
            bool good = true;
            int count = -1;
            int res = 1;
            foreach (var v in g[u])
            {
                if (v == par) continue;
                int cur = Dfs(u, v);
                if (count == -1)
                    count = cur;
                if (cur != count)
                    good = false;
                res += cur;
            }
            if (good) goodNodesCount++;
            return res;
        }
        Dfs(-1, 0);
        return goodNodesCount;
    }
}
