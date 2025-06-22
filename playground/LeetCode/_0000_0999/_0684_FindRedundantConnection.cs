using playground.Helpers;

namespace playground.LeetCode._0000_0999;

public class _0684_FindRedundantConnection
{
    public static int[] FindRedundantConnection(int[][] edges)
    {
        var res = Array.Empty<int>();
        int n = edges.Length + 1;
        var ds = new DisjointSet(n);
        foreach (var e in edges)
        {
            if (!ds.Union(e[0], e[1]))
                res = e;
        }
        return res;
    }
}
