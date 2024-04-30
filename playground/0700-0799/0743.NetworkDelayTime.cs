namespace playground;

public class NetworkDelayTime0743
{
    /// <summary>
    /// https://leetcode.com/problems/network-delay-time
    /// </summary>
    public static int NetworkDelayTime(int[][] times, int n, int k)
    {
        var g = new Dictionary<int, List<(int n, int w)>>();
        foreach (var t in times)
        {
            if (!g.ContainsKey(t[0])) g[t[0]] = new();
            g[t[0]].Add((t[1], t[2]));
        }

        var durations = new int[n + 1];
        Array.Fill(durations, int.MaxValue);
        durations[0] = durations[k] = 0;
        var q = new PriorityQueue<int, int>();
        q.Enqueue(k, 0);
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            if (!g.ContainsKey(u)) continue;
            foreach (var (v, w) in g[u])
            {
                if (durations[u] + w < durations[v])
                {
                    durations[v] = durations[u] + w;
                    q.Enqueue(v, durations[v]);
                }
            }
        }
        return durations.Any(x => x == int.MaxValue) ? -1 : durations.Max();
    }
}
