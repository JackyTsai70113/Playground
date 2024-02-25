namespace playground.UnionFinds;

public class MaxNumEdgesToRemoveClass
{
    /// <remarks>https://leetcode.com/problems/remove-max-number-of-edges-to-keep-graph-fully-traversable</remarks>
    public static int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        edges = edges.OrderBy(e => -e[0]).ToArray();
        var res = 0;

        var uf = new UnionFind(n + 1);
        int edgesIndex = 0;
        for (; edgesIndex < edges.Length; ++edgesIndex)
        {
            if (edges[edgesIndex][0] != 3) break;
            int u = edges[edgesIndex][1], v = edges[edgesIndex][2];
            if (uf.AreConnected(u, v))
            {
                res++;
            }
            else
            {
                uf.Connect(u, v);
            }
        }

        var uf1 = new UnionFind(uf);
        for (; edgesIndex < edges.Length; ++edgesIndex)
        {
            if (edges[edgesIndex][0] != 2) break;
            int u = edges[edgesIndex][1], v = edges[edgesIndex][2];
            if (uf1.AreConnected(u, v))
            {
                res++;
            }
            else
            {
                uf1.Connect(u, v);
            }
        }
        for (int i = 2; i < n + 1; ++i)
        {
            if (!uf1.AreConnected(1, i)) return -1;
        }

        var uf2 = new UnionFind(uf);
        for (; edgesIndex < edges.Length; ++edgesIndex)
        {
            if (edges[edgesIndex][0] != 1) break;
            int u = edges[edgesIndex][1], v = edges[edgesIndex][2];
            if (uf2.AreConnected(u, v))
            {
                res++;
            }
            else
            {
                uf2.Connect(u, v);
            }
        }
        for (int i = 2; i < n + 1; ++i)
        {
            if (!uf2.AreConnected(1, i)) return -1;
        }
        return res;
    }
}
