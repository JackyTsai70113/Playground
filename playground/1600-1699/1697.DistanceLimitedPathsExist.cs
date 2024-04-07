namespace playground;

public class DistanceLimitedPathsExist1697
{
    /// <summary>
    /// https://leetcode.com/problems/checking-existence-of-edge-length-limited-paths
    /// </summary>
    public static bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
    {
        edgeList = edgeList
            .OrderBy(x => x[2])
            .ToArray();
        var qs = queries
            .Select((x, i) => (p: x[0], q: x[1], limit: x[2], idx: i))
            .OrderBy(y => y.limit)
            .ToArray();

        var uf = new UnionFind(n);
        var res = new bool[queries.Length];
        int i = 0;
        foreach (var (p, q, limit, idx) in qs)
        {
            for (; i < edgeList.Length && edgeList[i][2] < limit; i++)
            {
                uf.Union(edgeList[i][0], edgeList[i][1]);
            }
            if (uf.Find(p) == uf.Find(q))
            {
                res[idx] = true;
            }
        }
        return res;
    }

    public class UnionFind
    {
        private readonly int[] groups;
        private readonly int[] ranks;
        public UnionFind(int n)
        {
            groups = new int[n];
            Array.Fill(groups, -1);
            ranks = new int[n];
            Array.Fill(ranks, 1);
        }

        public int Find(int node)
        {
            return groups[node] < 0 ? node : Find(groups[node]);
        }

        public void Union(int node1, int node2)
        {
            int g1 = Find(node1), g2 = Find(node2);
            if (g1 == g2) return;
            if (ranks[g2] > ranks[g1])
                (g1, g2) = (g2, g1);
            groups[g2] = g1;
            ranks[g1] += ranks[g2];
        }
    }
}
