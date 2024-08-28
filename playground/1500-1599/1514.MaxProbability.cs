namespace playground;

public class MaxProbability1514
{
    public static double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
    {
        var g = new List<(int u, double p)>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        for (int i = 0; i < edges.Length; i++)
        {
            g[edges[i][0]].Add((edges[i][1], succProb[i]));
            g[edges[i][1]].Add((edges[i][0], succProb[i]));
        }
        var probs = new double[n];
        var pq = new PriorityQueue<(int, double), double>();
        pq.Enqueue((start, 1), -1);
        while (pq.Count > 0)
        {
            var (u, p) = pq.Dequeue();
            if (u == end) return p;
            if (p > probs[u])
            {
                probs[u] = p;
                foreach (var (v, pp) in g[u])
                {
                    pq.Enqueue((v, p * pp), -p * pp);
                }
            }
        }
        return 0;
    }
}
