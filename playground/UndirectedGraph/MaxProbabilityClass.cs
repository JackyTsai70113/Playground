namespace playground.UndirectedGraph;

public class MaxProbabilityClass
{
    public static double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
    {
        var graph = Enumerable.Range(0, n).Select(i => new List<(int v, double p)>()).ToArray();
        for (int i = 0; i < edges.Length; ++i)
        {
            graph[edges[i][0]].Add((edges[i][1], succProb[i]));
            graph[edges[i][1]].Add((edges[i][0], succProb[i]));
        }
        if (graph[end].Count == 0)
        {
            return 0;
        }

        // bfs 會優於 dfs
        var pbs = new double[n];
        var q = new Queue<int>();
        q.Enqueue(start);
        pbs[start] = 1;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            if (u == end)
            {
                continue;
            }
            foreach (var (v, p) in graph[u])
            {
                if (pbs[u] * p > pbs[v])
                {
                    pbs[v] = pbs[u] * p;
                    q.Enqueue(v);
                }
            }
        }
        return pbs[end];
    }
}
