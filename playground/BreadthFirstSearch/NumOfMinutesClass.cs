namespace playground.BreadthFirstSearch;

public class NumOfMinutesClass
{
    /// <summary>
    /// https://leetcode.com/problems/time-needed-to-inform-all-employees
    /// </summary>
    public static int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
    {
        var graph = new List<(int v, int time)>[n];
        for (int i = 0; i < n; i++)
        {
            if (manager[i] != -1)
            {
                graph[manager[i]] = graph[manager[i]] ?? new();
                graph[manager[i]].Add((i, informTime[i]));
            }
        }
        var q = new Queue<(int v, int time)>();
        q.Enqueue((headID, informTime[headID]));
        var res = informTime[headID];
        while (q.Count > 0)
        {
            var (u, uTime) = q.Dequeue();
            if (graph[u] == null)
                continue;
            foreach (var (v, vTime) in graph[u])
            {
                q.Enqueue((v, uTime + vTime));
                res = Math.Max(res, uTime + vTime);
            }
        }
        return res;
    }
}

