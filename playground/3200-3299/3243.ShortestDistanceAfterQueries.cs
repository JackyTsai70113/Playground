namespace playground;

public class ShortestDistanceAfterQueries3243
{
    public static int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        for (int i = 0; i < n; i++)
        {
            g[i].Add(i + 1);
        }
        var res = new List<int>();
        foreach (var q in queries)
        {
            g[q[0]].Add(q[1]);
            var seen = new bool[n];
            seen[0] = true;
            var queue = new Queue<int>();
            queue.Enqueue(0);
            int cur = 0;
            bool isBreak = false;
            while (queue.Count > 0 && !isBreak)
            {
                for (int i = queue.Count - 1; i >= 0; i--)
                {
                    var u = queue.Dequeue();
                    if (u == n - 1)
                    {
                        isBreak = true;
                        break;
                    }
                    foreach (var v in g[u])
                    {
                        if (!seen[v])
                        {
                            seen[v] = true;
                            queue.Enqueue(v);
                        }
                    }
                }
                cur++;
            }
            res.Add(cur - 1);
        }
        return res.ToArray();
    }
}
