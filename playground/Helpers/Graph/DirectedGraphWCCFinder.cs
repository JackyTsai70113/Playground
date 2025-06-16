namespace playground.Helpers.Graph;

public class DirectedGraphWCCFinder : Graph
{
    public DirectedGraphWCCFinder(int n, int[][] edges) : base(n)
    {
        foreach (var e in edges)
        {
            adj[e[0]].Add(e[1]);
            adj[e[1]].Add(e[0]);
        }
    }

    public List<List<int>> FindConnectedComponents_BFS()
    {
        ResetVisited();
        var connectedComponents = new List<List<int>>();

        for (int i = 0; i < N; i++)
        {
            if (visited[i]) continue;
            var connectedComponent = new List<int>();
            BFS(i, connectedComponent);
            connectedComponents.Add(connectedComponent);
        }
        return connectedComponents;
    }

    public List<List<int>> FindConnectedComponents_DFS()
    {
        ResetVisited();
        var connectedComponents = new List<List<int>>();

        for (int i = 0; i < N; i++)
        {
            if (visited[i]) continue;
            var connectedComponent = new List<int>();
            DFS(i, connectedComponent);
            connectedComponents.Add(connectedComponent);
        }
        return connectedComponents;
    }

    public void BFS(int start, List<int> currentComponent)
    {
        var q = new Queue<int>();
        q.Enqueue(start);
        visited[start] = true;
        currentComponent.Add(start);

        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var v in adj[u])
            {
                if (visited[v]) continue;
                q.Enqueue(v);
                visited[v] = true;
                currentComponent.Add(v);
            }
        }
    }

    public void DFS(int start, List<int> currentComponent)
    {
        var q = new Queue<int>();
        q.Enqueue(start);
        visited[start] = true;
        currentComponent.Add(start);

        foreach (var v in adj[start])
        {
            if (visited[v]) continue;
            DFS(v, currentComponent);
        }
    }
}
