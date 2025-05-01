namespace playground;

public class _3243_ShortestDistanceAfterQueries
{
    // BFS
    public static int[] ShortestDistanceAfterQueries(int n, int[][] qs)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new() { i + 1 };
        var res = new int[qs.Length];
        var pq = new PriorityQueue<(int u, int d), int>();
        var dists = new int[n];
        for (int i = 1; i < n; i++) dists[i] = i;

        for (int i = 0; i < qs.Length; i++)
        {
            g[qs[i][0]].Add(qs[i][1]);
            pq.Enqueue((0, 0), 0);
            while (pq.Count > 0)
            {
                var (u, d) = pq.Dequeue();
                if (u == n - 1)
                {
                    res[i] = d;
                    break;
                }
                foreach (var v in g[u])
                {
                    if (dists[u] + 1 <= dists[v])
                    {
                        dists[v] = dists[u] + 1;
                        pq.Enqueue((v, dists[v]), dists[v]);
                    }
                }
            }
        }
        return res;
    }

    // DFS
    public static int[] ShortestDistanceAfterQueries2(int n, int[][] qs)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new() { i + 1 };
        var res = new int[qs.Length];
        var q = new Queue<int>();
        var seen = new bool[n];
        for (int i = 0; i < qs.Length; i++)
        {
            q.Clear();
            Array.Fill(seen, false);

            g[qs[i][0]].Add(qs[i][1]);
            q.Enqueue(0);
            seen[0] = true;
            int step = -1;
            bool isBreak = false;
            while (q.Count > 0 && !isBreak)
            {
                step++;
                for (int j = q.Count; j > 0; j--)
                {
                    var u = q.Dequeue();
                    if (u == n - 1)
                    {
                        res[i] = step;
                        isBreak = true;
                        break;
                    }
                    foreach (var v in g[u])
                    {
                        if (!seen[v])
                        {
                            seen[v] = true;
                            q.Enqueue(v);
                        }
                    }
                }
            }
        }
        return res;
    }

    public static int[] ShortestDistanceAfterQueries3(int n, int[][] qs)
    {
        var g = new List<int>[n];
        var dists = new int[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = new() { i + 1 };
            dists[i] = i;
        }
        var res = new int[qs.Length];
        for (int i = 0; i < qs.Length; i++)
        {
            g[qs[i][0]].Add(qs[i][1]);
            for (int u = qs[i][0]; u < n - 1; u++)
            {
                foreach (var v in g[u])
                {
                    dists[v] = Math.Min(dists[v], dists[u] + 1);
                }
            }
            res[i] = dists[n - 1];
        }
        return res;
    }
}
