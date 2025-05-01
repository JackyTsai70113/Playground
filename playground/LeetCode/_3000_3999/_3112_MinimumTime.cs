namespace playground;

public class _3112_MinimumTime
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-visit-disappearing-nodes
    /// </summary>
    public static int[] MinimumTime(int n, int[][] edges, int[] disappear)
    {
        var g = new List<(int, int)>[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = new();
        }
        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }
        var res = new int[n];
        Array.Fill(res, int.MaxValue);
        res[0] = 0;
        var q = new PriorityQueue<int, int>();
        q.Enqueue(0, 0);
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var (v, t) in g[u])
            {
                if (t + res[u] < disappear[v] && t + res[u] < res[v])
                {
                    res[v] = t + res[u];
                    q.Enqueue(v, res[v]);
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            res[i] = res[i] == int.MaxValue ? -1 : res[i];
        }
        return res;
    }
}
