namespace playground;

public class MinimumTime2050
{
    /// <summary>
    /// https://leetcode.com/problems/parallel-courses-iii
    /// </summary>
    public static int MinimumTime(int n, int[][] rs, int[] time)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        int[] indegree = new int[n], preTime = new int[n];
        foreach (var r in rs)
        {
            g[r[0] - 1].Add(r[1] - 1);
            indegree[r[1] - 1]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (indegree[i] == 0)
                q.Enqueue(i);
        }
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            preTime[u] += time[u];
            foreach (var v in g[u])
            {
                preTime[v] = Math.Max(preTime[v], preTime[u]);
                indegree[v]--;
                if (indegree[v] == 0)
                    q.Enqueue(v);
            }
        }
        return preTime.Max();
    }
}
