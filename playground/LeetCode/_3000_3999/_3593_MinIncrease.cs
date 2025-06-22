namespace playground.LeetCode._3000_3999;

public class _3593_MinIncrease
{
    private List<int>[] adj;
    private int[] nodeCosts;
    private int incrementsCount;
    public int MinIncrease(int n, int[][] edges, int[] cost)
    {
        adj = new List<int>[n];
        for (int i = 0; i < n; i++) adj[i] = new();

        foreach (var e in edges)
        {
            adj[e[0]].Add(e[1]);
            adj[e[1]].Add(e[0]);
        }

        nodeCosts = cost;
        incrementsCount = 0;

        DFS(0, -1);

        return incrementsCount;
    }

    private long DFS(int u, int p)
    {
        bool isLeaf = true;
        foreach (int v in adj[u])
        {
            if (v != p)
            {
                isLeaf = false;
                break;
            }
        }

        if (isLeaf)
        {
            return nodeCosts[u];
        }

        long maxChildPathSum = 0;
        List<long> currentChildrenPathSums = new List<long>();

        foreach (int v in adj[u])
        {
            if (v != p)
            {
                long childPathSum = DFS(v, u);
                currentChildrenPathSums.Add(childPathSum);
                maxChildPathSum = Math.Max(maxChildPathSum, childPathSum);
            }
        }

        foreach (long s in currentChildrenPathSums)
        {
            if (maxChildPathSum > s)
            {
                incrementsCount++;
            }
        }

        return nodeCosts[u] + maxChildPathSum;
    }
}