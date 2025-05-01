namespace playground.LeetCode._0000_0999;

public class _0815_NumBusesToDestination
{
    /// <summary>
    /// https://leetcode.com/problems/bus-routes
    /// </summary>
    public static int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0;
        int n = routes.Length;
        var routeToBuses = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            foreach (var stop in routes[i])
            {
                if (!routeToBuses.ContainsKey(stop)) routeToBuses[stop] = new();
                routeToBuses[stop].Add(i);
            }
        }
        if (!routeToBuses.ContainsKey(source)) return -1;
        var q = new Queue<int>();
        var seenBus = new HashSet<int>(routeToBuses[source]);
        var seenStop = new HashSet<int> { source };
        var busCount = 1;
        foreach (var bus in routeToBuses[source])
        {
            q.Enqueue(bus);
        }
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; i--)
            {
                var bus = q.Dequeue();
                foreach (var stop in routes[bus])
                {
                    if (stop == target) return busCount;
                    if (seenStop.Contains(stop)) continue;
                    seenStop.Add(stop);
                    foreach (var nextBus in routeToBuses[stop])
                    {
                        if (seenBus.Contains(nextBus)) continue;
                        seenBus.Add(nextBus);
                        q.Enqueue(nextBus);
                    }
                }
            }
            busCount++;
        }
        return -1;
    }
}
