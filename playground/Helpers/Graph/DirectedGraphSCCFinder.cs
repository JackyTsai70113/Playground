namespace playground.Helpers.Graph;

public class DirectedGraphSCCFinder : Graph
{
    private readonly List<int>[] adjReverse;
    private readonly Stack<int> finishOrderStack = new();
    public DirectedGraphSCCFinder(int n, int[][] edges) : base(n)
    {
        adjReverse = new List<int>[N];
        for (int i = 0; i < N; i++) adjReverse[i] = new();
        foreach (var e in edges)
        {
            adj[e[0]].Add(e[1]);
            adjReverse[e[1]].Add(e[0]);
        }
    }

    /// <summary>
    /// Kosaraju's algorithm to find strongly connected components (SCCs) in a directed graph.
    /// </summary>
    /// <returns></returns>
    public List<List<int>> FindStronglyConnectedComponents()
    {
        ResetVisited();

        // Step 1: Perform DFS to get finish order
        for (int i = 0; i < N; i++)
        {
            if (visited[i]) continue;
            Dfs(i);
        }

        ResetVisited();
        var connectedComponents = new List<List<int>>();

        // Step 2: Process nodes in reverse finish order
        while (finishOrderStack.Count > 0)
        {
            var u = finishOrderStack.Pop();
            if (visited[u]) continue;
            var connectedComponent = new List<int>();
            Dfs_Reverse(u, connectedComponent);
            connectedComponents.Add(connectedComponent);
        }
        return connectedComponents;
    }

    public void Dfs(int u)
    {
        visited[u] = true;
        foreach (var v in adj[u])
        {
            if (visited[v]) continue;
            Dfs(v);
        }
        finishOrderStack.Push(u);
    }

    public void Dfs_Reverse(int u, List<int> connectedComponent)
    {
        visited[u] = true;
        connectedComponent.Add(u);
        foreach (var v in adjReverse[u])
        {
            if (visited[v]) continue;
            Dfs_Reverse(v, connectedComponent);
        }
    }
}
