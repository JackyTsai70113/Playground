namespace playground;

public class NetworkDelayTime0743
{
    /// <summary>
    /// https://leetcode.com/problems/network-delay-time
    /// </summary>
    public static int NetworkDelayTime(int[][] times, int n, int k)
    {
        var g = Graph.BuildDWG(n + 1, times);
        var dist = Graph.Dijkstra(k, g);
        dist[0] = 0;
        return dist.Any(x => x == int.MaxValue) ? -1 : dist.Max();
    }
}
