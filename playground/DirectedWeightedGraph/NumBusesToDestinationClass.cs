namespace playground.DirectedGraph;

public class NumBusesToDestinationClass
{
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
        var graph = new Dictionary<int, HashSet<int>>();
        for (int bus = 0; bus < routes.Length; ++bus)
        {
            foreach (var station in routes[bus])
            {
                if (!graph.ContainsKey(station)) graph[station] = new();
                graph[station].Add(bus);
            }
        }
        var seenBus = new HashSet<int>();
        var seenStation = new HashSet<int>();
        var buses = -1;
        var q = new Queue<int>();
        q.Enqueue(source);
        seenStation.Add(source);
        while (q.Count > 0)
        {
            buses++;
            for (int i = q.Count - 1; i >= 0; --i)
            {
                var station = q.Dequeue();
                if (station == target) return buses;
                foreach (var bus in graph[station])
                {
                    if (seenBus.Contains(bus)) continue;
                    seenBus.Add(bus);
                    foreach (var neiStation in routes[bus])
                    {
                        if (seenStation.Contains(neiStation)) continue;
                        seenStation.Add(neiStation);
                        q.Enqueue(neiStation);
                    }
                }
            }
        }
        return -1;
    }
}