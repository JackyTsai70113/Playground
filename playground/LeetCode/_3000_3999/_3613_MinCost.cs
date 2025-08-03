using playground.Helpers;

namespace playground.LeetCode._3000_3999;

public class _3613_MinCost
{
    public static int MinCost(int n, int[][] edges, int k)
    {
        if (k == n) return 0;
        Array.Sort(edges, (a, b) => a[2].CompareTo(b[2]));

        DisjointSet ds = new(n);
        int maxCost = 0;

        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1], w = edge[2];
            if (ds.Union(u, v))
            {
                maxCost = w;
                n--;
            }
            if (n <= k) break;
        }

        return maxCost;
    }
}
