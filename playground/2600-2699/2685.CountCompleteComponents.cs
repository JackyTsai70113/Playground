namespace playground;

public class CountCompleteComponents2685
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-complete-components
    /// </summary>
    public static int CountCompleteComponents(int n, int[][] edges)
    {
        int[] edgeCounts = new int[n];
        var uf = new UnionFind(n);
        foreach (var e in edges)
        {
            int g1 = uf.Find(e[0]), g2 = uf.Find(e[1]);
            int count1 = edgeCounts[g1], count2 = edgeCounts[g2];
            if (g1 != g2)
            {
                uf.Union(e[0], e[1]);
                g1 = uf.Find(e[0]);
                edgeCounts[g1] = count1 + count2 + 1;
            }
            else
            {
                edgeCounts[g1]++;
            }
        }

        var res = 0;
        for (int i = 0; i < n; i++)
        {
            var g = uf.Find(i);
            if (g != i) continue;
            if (edgeCounts[g] == uf.ranks[g] * (uf.ranks[g] - 1) / 2)
                res++;
        }
        return res;
    }

    public class UnionFind
    {
        private readonly int[] groups;
        public readonly int[] ranks;
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