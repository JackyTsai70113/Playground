namespace playground;

public class NumOfMinutes1376
{
    /// <summary>
    /// https://leetcode.com/problems/time-needed-to-inform-all-employees
    /// </summary>
    public static int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        for (int i = 0; i < n; i++)
        {
            if (manager[i] != -1)
                g[manager[i]].Add(i);
        }

        var q = new Queue<int>();
        q.Enqueue(headID);
        int res = 0;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            res = Math.Max(res, informTime[u]);
            foreach (var v in g[u])
            {
                informTime[v] += informTime[u];
                q.Enqueue(v);
            }
        }
        return res;
    }

    public static int NumOfMinutes2(int n, int headID, int[] manager, int[] informTime)
    {
        int dfs(int i)
        {
            if (manager[i] == -1) return informTime[i];
            informTime[i] += dfs(manager[i]);
            manager[i] = -1;
            return informTime[i];
        }
        return Enumerable.Range(0, n).Max(i => dfs(i));
    }
}
