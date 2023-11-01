namespace playground.DirectedWeightedGraph;

public class MinimumTimeClass
{
    /// <summary>
    /// https://leetcode.com/problems/parallel-courses-iii
    /// </summary>
    public static int MinimumTime(int n, int[][] rs, int[] time)
    {
        var graph = new List<int>[n];
        for (int i = 0; i < n; ++i)
            graph[i] = new();
        int[] preCount = new int[n], results = new int[n];
        foreach (var r in rs)
        {
            graph[r[0] - 1].Add(r[1] - 1);
            preCount[r[1] - 1]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; ++i)
        {
            if (preCount[i] == 0)
                q.Enqueue(i);
        }
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            results[u] += time[u];
            foreach (var v in graph[u])
            {
                results[v] = Math.Max(results[v], results[u]);
                preCount[v]--;
                if (preCount[v] == 0)
                    q.Enqueue(v);
            }
        }
        return results.Max();
    }
}
