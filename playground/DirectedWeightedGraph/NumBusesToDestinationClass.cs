namespace playground.DirectedGraph;

public class NumBusesToDestinationClass
{
    /// <summary>
    /// https://leetcode.com/problems/bus-routes
    /// </summary>
    public static int NumBusesToDestination(int[][] routes, int source, int target)
    {
        int n = routes.Length;
        var graph = new Dictionary<int, HashSet<int>>();
        for (int bus = 0; bus < n; ++bus)
        {
            foreach (var station in routes[bus])
            {
                if (!graph.ContainsKey(station))
                    graph[station] = new HashSet<int>();
                graph[station].Add(bus);
            }
        }

        var q = new Queue<(int station, int buses)>();
        q.Enqueue((source, 0));
        var seenBus = new HashSet<int>();
        var seenStation = new HashSet<int> { source };

        while (q.Count > 0)
        {
            var (curStation, buses) = q.Dequeue();
            if (curStation == target) return buses;
            foreach (var bus in graph[curStation])
            {
                if (seenBus.Contains(bus)) continue;
                seenBus.Add(bus);
                foreach (var station in routes[bus])
                {
                    if (seenStation.Contains(station)) continue;
                    seenStation.Add(station);
                    q.Enqueue((station, buses + 1));
                }
            }
        }
        return -1;
    }

    public static int NumBusesToDestination2(int[][] routes, int source, int target)
    {
        if (source == target) return 0;
        int n = routes.Length;
        var busToRoutes = new HashSet<int>[n];
        var routeToBuses = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; ++i)
        {
            busToRoutes[i] = new();
            for (int j = 0; j < routes[i].Length; ++j)
            {
                busToRoutes[i].Add(routes[i][j]);
                if (!routeToBuses.ContainsKey(routes[i][j]))
                    routeToBuses[routes[i][j]] = new();
                routeToBuses[routes[i][j]].Add(i);
            }
        }
        var q = new Queue<int>();
        var seenBus = new HashSet<int>();
        var seenRoute = new HashSet<int>();
        if (routeToBuses.ContainsKey(source))
        {
            seenRoute.Add(source);
            foreach (var bus in routeToBuses[source])
            {
                q.Enqueue(bus);
                seenBus.Add(bus);
            }
        }
        var res = 0;
        while (q.Count > 0)
        {
            res++;
            for (int i = q.Count; i > 0; --i)
            {
                var bus = q.Dequeue();
                if (busToRoutes[bus].Contains(target)) return res;
                foreach (var route in busToRoutes[bus])
                {
                    if (seenRoute.Contains(route)) continue;
                    seenRoute.Add(route);
                    foreach (var nextBus in routeToBuses[route])
                    {
                        if (seenBus.Contains(nextBus)) continue;
                        seenBus.Add(nextBus);
                        q.Enqueue(nextBus);
                    }
                }
            }
        }
        return -1;
    }
}