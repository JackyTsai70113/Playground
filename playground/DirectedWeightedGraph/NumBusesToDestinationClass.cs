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
                if(seenBus.Contains(bus)) continue;
                seenBus.Add(bus);
                foreach(var station in routes[bus]){
                    if(seenStation.Contains(station)) continue;
                    seenStation.Add(station);
                    q.Enqueue((station, buses + 1));
                }
            }
        }
        return -1;
    }
}
