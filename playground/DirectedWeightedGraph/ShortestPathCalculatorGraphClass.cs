namespace playground.DirectedWeightedGraph;

public class ShortestPathCalculatorGraphClass
{
    readonly int n;
    readonly List<(int node, int dist)>[] graph;
    public ShortestPathCalculatorGraphClass(int n, int[][] edges)
    {
        this.n = n;
        graph = Enumerable.Range(0, n).Select(_ => new List<(int, int)>()).ToArray();
        foreach (var e in edges)
            AddEdge(e);
    }

    public void AddEdge(int[] e)
    {
        graph[e[0]].Add((e[1], e[2]));
    }

    public int ShortestPath(int node1, int node2)
    {
        var path = Enumerable.Repeat(int.MaxValue, n).ToArray();
        path[node1] = 0;
        var q = new PriorityQueue<(int node, int dist), int>();
        q.Enqueue((node1, path[node1]), path[node1]);
        while (q.Count > 0)
        {
            var (node, dist) = q.Dequeue();
            if (node == node2) return dist;
            foreach ((int nei, int neiDist) in graph[node]){
                if (path[nei] > path[node] + neiDist){
                    path[nei] = path[node] + neiDist;
                    q.Enqueue((nei, path[nei]), path[nei]);
                }
            }
        }
        return -1;
    }
}
