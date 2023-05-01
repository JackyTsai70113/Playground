namespace playground.DirectedWeightedGraph.Minimum;

public class MinimumCostClass
{
    public static int MinimumCost(int[] s, int[] t, int[][] roads)
    {
        var filterRoads = new List<int[]>();
        foreach (var r in roads)
        {
            if (r[4] < Math.Abs(r[0] - r[2]) + Math.Abs(r[1] - r[3]))
            {
                filterRoads.Add(r);
            }
        }

        var dists = new Dictionary<(int x, int y), int> { [(s[0], s[1])] = 0 };
        var pq = new PriorityQueue<(int, (int x, int y)), int>();
        for (pq.Enqueue((0, (s[0], s[1])), 0); pq.Count > 0;)
        {
            var (curDist, curPoint) = pq.Dequeue();
            foreach (var r in filterRoads)
            {
                int x1 = r[0], y1 = r[1], x2 = r[2], y2 = r[3], cost = r[4];
                if (!dists.TryGetValue((x2, y2), out var val) ||
                    val > curDist + Math.Abs(x1 - curPoint.x) + Math.Abs(y1 - curPoint.y) + cost)
                {
                    dists[(x2, y2)] = curDist + Math.Abs(x1 - curPoint.x) + Math.Abs(y1 - curPoint.y) + cost;
                    pq.Enqueue((dists[(x2, y2)], (x2, y2)), dists[(x2, y2)]);
                }
            }
        }
        int res = Math.Abs(t[0] - s[0]) + Math.Abs(t[1] - s[1]);
        foreach (var r in filterRoads)
        {
            int x2 = r[2], y2 = r[3];
            if (dists.TryGetValue((x2, y2), out var val))
            {
                res = Math.Min(res, val + Math.Abs(t[0] - x2) + Math.Abs(t[1] - y2));
            }
        }
        return res;
    }
}
