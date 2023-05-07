namespace playground.UndirectedGraph;

public class MakeConnectedClass
{
    /// <remarks>https://leetcode.com/problems/number-of-operations-to-make-network-connected/</remarks>
    public static int MakeConnected(int n, int[][] A)
    {
        if (A.Length < n - 1)
        {
            return -1;
        }
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var a in A)
        {
            graph[a[0]].Add(a[1]);
            graph[a[1]].Add(a[0]);
        }

        var seen = new bool[n];
        void dfs(int x)
        {
            seen[x] = true;
            foreach (var neighbor in graph[x])
            {
                if (!seen[neighbor])
                {
                    dfs(neighbor);
                }
            }
        }

        var componentsCount = -1;
        for (int i = 0; i < n; ++i)
        {
            if (!seen[i])
            {
                componentsCount++;
                dfs(i);
            }
        }
        return componentsCount;
    }
}
