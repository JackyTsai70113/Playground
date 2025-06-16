namespace playground.Helpers.Graph;

public class Graph
{
    protected int N;
    protected List<int>[] adj;
    protected bool[] visited;

    public Graph(int n)
    {
        N = n;
        adj = new List<int>[N];
        for (int i = 0; i < N; i++) adj[i] = new();
        visited = new bool[N];
    }

    public void ResetVisited()
    {
        Array.Fill(visited, false);
    }
}
