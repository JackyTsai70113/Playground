namespace playground.DirectedWeightedGraph.Minimum;

public class MinimumTemplateClass
{
    public static int Minimum(int[] start, int[] target, int[][] edges)
    {
        var dists = new Dictionary<(int x, int y), int>();
        var pq = new PriorityQueue<((int x, int y), int dist), int>();

        dists[P(start)] = 0;
        pq.Enqueue((P(start), 0), 0);
        while (pq.Count > 0)
        {
            var (p, startAndpDist) = pq.Dequeue();
            foreach (var edge in edges)
            {
                var (u, v, uAndvDist) = ParseEdge(edge);
                var pAnduDist = GetDistance(p, u);
                if (!dists.TryGetValue(v, out var startAndvDist) ||
                    startAndvDist > startAndpDist + pAnduDist + uAndvDist)
                {
                    dists[v] = startAndpDist + pAnduDist + uAndvDist;
                    pq.Enqueue((v, dists[v]), dists[v]);
                }
            }
        }
        var startAndTargetDistance = GetDistance(P(start), P(target));
        foreach (var edge in edges)
        {
            var (_, v, _) = ParseEdge(edge);
            startAndTargetDistance = Math.Min(startAndTargetDistance, dists[v] + GetDistance(v, P(target)));
        }
        return startAndTargetDistance;
    }

    public static (int x, int y) P(int[] edge)
    {
        return (edge[0], edge[1]);
    }

    public static ((int x, int y) u, (int x, int y) v, int dist) ParseEdge(int[] edge)
    {
        var u = (edge[0], edge[1]);
        var v = (edge[2], edge[3]);
        var dist = edge[4];
        return (u, v, dist);
    }

    public static int GetDistance((int x, int y) p1, (int x, int y) p2)
    {
        return Math.Abs(p1.x - p2.x) + Math.Abs(p1.y - p2.y);
    }
}