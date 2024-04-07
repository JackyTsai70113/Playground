namespace playground;

public class CanTraverseAllPairs2709
{
    /// <summary>
    /// https://leetcode.com/problems/greatest-common-divisor-traversal
    /// </summary>
    public static bool CanTraverseAllPairs(int[] nums)
    {
        if (nums.Length == 1) return true;
        int n = nums.Length;
        var index = new Dictionary<int, int>();
        var uf = new UnionFind(n);
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] == 1) return false;
            for (int p = 2; p <= (int)Math.Sqrt(nums[i]); ++p)
            {
                if (nums[i] % p != 0) continue;
                if (index.TryGetValue(p, out var val))
                    uf.Union(val, i);
                else
                    index[p] = i;
                while (nums[i] % p == 0) nums[i] /= p;
            }
            if (nums[i] > 1)
            {
                if (index.TryGetValue(nums[i], out var val))
                    uf.Union(val, i);
                else
                    index[nums[i]] = i;
            }
        }
        return uf.ranks[uf.Find(0)] == n;
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
