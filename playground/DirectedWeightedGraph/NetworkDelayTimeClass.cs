namespace playground.DirectedWeightedGraph;

public class NetworkDelayTimeClass
{
    public static int NetworkDelayTime(int[][] edges, int n, int k)
    {
        var graph = new Dictionary<int, HashSet<(int node, int w)>>();
        foreach (var e in edges)
        {
            if (!graph.ContainsKey(e[0])) graph[e[0]] = new HashSet<(int, int)>();
            graph[e[0]].Add((e[1], e[2]));
        }

        var dist = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();

        PriorityQueue<(int, int), int> pq = new();
        pq.Enqueue((k, 0), 0);
        dist[0] = 0;
        dist[k] = 0;
        while (pq.Count > 0)
        {
            var (i, _) = pq.Dequeue();
            if (!graph.ContainsKey(i)) continue;
            foreach ((int nei, int w) in graph[i])
            {
                if (dist[nei] == int.MaxValue || dist[nei] > dist[i] + w)
                {
                    dist[nei] = dist[i] + w;
                    pq.Enqueue((nei, w), w);
                }
            }
        }
        return dist.Max() == int.MaxValue ? -1 : dist.Max();
    }
}
