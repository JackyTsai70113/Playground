namespace playground.LeetCode._0000_0999;

public class _0947_RemoveStones
{
    public static int RemoveStones(int[][] A)
    {
        int n = A.Length;
        var ds = new DisjointSet(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (A[i][0] == A[j][0] || A[i][1] == A[j][1])
                    ds.Join(i, j);
            }
        }
        int groupsCount = 0;
        for (int i = 0; i < n; i++)
            if (ds.groups[i] == i)
                groupsCount++;
        return n - groupsCount;
    }

    public class DisjointSet
    {
        public int[] groups;
        public int[] ranks;
        public DisjointSet(int n)
        {
            groups = new int[n];
            for (int i = 0; i < n; i++) groups[i] = i;
            ranks = new int[n];
            Array.Fill(ranks, 1);
        }

        public int Find(int node)
        {
            return groups[node] = groups[node] == node ? groups[node] : Find(groups[node]);
        }

        public bool Join(int node1, int node2)
        {
            int g1 = Find(node1), g2 = Find(node2);
            if (g1 == g2)
                return false;
            groups[g2] = g1;
            ranks[g1] += ranks[g2];
            return true;
        }
    }
}
