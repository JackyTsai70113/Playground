namespace playground;

public class MinimumCost2662
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-of-a-path-with-special-roads
    /// </summary>
    public static int MinimumCost(int[] s, int[] t, int[][] roads)
    {
        var filteredRoads = new List<int[]>();
        foreach (var r in roads)
        {
            if (r[4] < Math.Abs(r[2] - r[0]) + Math.Abs(r[3] - r[1]))
                filteredRoads.Add(r);
        }
        var d = new Dictionary<(int x, int y), int> { [(s[0], s[1])] = 0 };

        var pq = new PriorityQueue<(int, int, int), int>();
        pq.Enqueue((s[0], s[1], 0), 0);
        while (pq.Count > 0)
        {
            var (x0, y0, cost) = pq.Dequeue();
            foreach (var r in filteredRoads)
            {
                if (!d.ContainsKey((r[2], r[3])) ||
                    d[(r[2], r[3])] > cost + Math.Abs(x0 - r[0]) + Math.Abs(y0 - r[1]) + r[4])
                {
                    d[(r[2], r[3])] = cost + Math.Abs(x0 - r[0]) + Math.Abs(y0 - r[1]) + r[4];
                    pq.Enqueue((r[2], r[3], d[(r[2], r[3])]), d[(r[2], r[3])]);
                }
            }
        }
        var res = t[0] - s[0] + t[1] - s[1];
        foreach (var r in filteredRoads)
            res = Math.Min(res, d[(r[2], r[3])] + t[0] - r[2] + t[1] - r[3]);
        return res;
    }
}
