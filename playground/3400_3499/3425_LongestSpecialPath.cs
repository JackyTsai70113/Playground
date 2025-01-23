namespace playground._3400_3499;

public class _3425_LongestSpecialPath
{
    public static int[] LongestSpecialPath(int[][] edges, int[] nums)
    {
        int n = nums.Length;
        var g = new List<(int v, int d)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }
        var dists = new int[n];
        void InitDistance(int par, int u)
        {
            foreach (var (v, d) in g[u])
            {
                if (v != par)
                {
                    dists[v] = dists[u] + d;
                    InitDistance(u, v);
                }
            }
        }
        InitDistance(-1, 0);

        int[] res = new int[] { -1, 0 };
        List<int> nodes = new List<int>();
        Dictionary<int, int> lastDict = new();
        void Dfs(int par, int u, int leftIndex, int depth)
        {
            int lastIndex = lastDict.GetValueOrDefault(nums[u], -1);
            int originalLeftIndex = leftIndex;
            leftIndex = Math.Max(leftIndex, lastIndex);
            if (nodes.Count == depth)
            {
                nodes.Add(u);
            }
            else
            {
                nodes[depth] = u;
            }
            int curLen = dists[nodes[depth]] - dists[nodes[leftIndex + 1]];
            int curNumber = depth - leftIndex;
            if (curLen > res[0])
            {
                res[0] = curLen;
                res[1] = curNumber;
            }
            else if (curLen == res[0])
            {
                res[1] = Math.Min(res[1], curNumber);
            }
            lastDict[nums[u]] = depth;

            foreach (var (v, d) in g[u])
            {
                if (par != v)
                    Dfs(u, v, leftIndex, depth + 1);
            }

            lastDict[nums[u]] = lastIndex;
        }
        Dfs(-1, 0, -1, 0);
        return res;
    }
}
