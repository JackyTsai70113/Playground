using playground.Helpers;

namespace playground.LeetCode._3000_3999;

public class _3608_MinTime
{

    private static bool Check(int t_val, int n, int[][] edges, int k)
    {
        var ds = new DisjointSet(n);

        foreach (var e in edges)
        {
            int u = e[0];
            int v = e[1];
            int time = e[2];

            if (time > t_val)
            {
                ds.Union(u, v);
            }
        }

        return ds.groups.ToHashSet().Count >= k;
    }

    public static int MinTime(int n, int[][] edges, int k)
    {
        int l = 0, r = 1_000_000_000;
        int res = r;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (Check(mid, n, edges, k))
            {
                res = mid;
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }

        return res;
    }
}
