namespace playground;

public class MaxNumEdgesToRemove1579
{
    /// <summary>
    /// https://leetcode.com/problems/remove-max-number-of-edges-to-keep-graph-fully-traversable
    /// </summary>
    public static int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        Array.Sort(edges, (x, y) => y[0] - x[0]);
        DisjointSet ds1 = new(n + 1), ds2 = new(n + 1);
        int res = 0;
        foreach (var e in edges)
        {
            if (e[0] == 3)
            {
                if (!ds1.Union(e[1], e[2])) res++;
                ds2.Union(e[1], e[2]);
            }
            else if (e[0] == 2)
            {
                if (!ds2.Union(e[1], e[2])) res++;
            }
            else
            {
                if (!ds1.Union(e[1], e[2])) res++;
            }
        }
        int group1 = ds1.Find(1), group2 = ds2.Find(2);
        for (int i = 2; i <= n; i++)
        {
            if (group1 != ds1.Find(i))
                return -1;
            if (group2 != ds2.Find(i))
                return -1;
        }
        return res;
    }

    public class DisjointSet
    {
        readonly int[] groups;
        public DisjointSet(int n)
        {
            groups = Enumerable.Range(0, n).ToArray();
        }
        public int Find(int node)
        {
            if (groups[node] != node)
                groups[node] = Find(groups[node]);
            return groups[node];
        }
        public bool Union(int node1, int node2)
        {
            int group1 = Find(node1);
            int group2 = Find(node2);
            if (group1 == group2)
                return false;
            groups[group2] = group1;
            return true;
        }
    }
}
