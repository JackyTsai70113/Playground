namespace playground.LeetCode._0000_0999;

public class _3547_MaxScore
{
    public static long MaxScore(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }

        var cycle = new List<int>();
        var path = new List<int>();
        // bfs
        var seen = new bool[n];
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (seen[i]) continue;
            seen[i] = true;
            var nodes = new List<int> { i };
            q.Enqueue(i);
            while(q.Count>0)
            {
                var u = q.Dequeue();
                foreach (var v in g[u])
                {
                    if (seen[v]) continue;
                    seen[v] = true;
                    nodes.Add(v);
                    q.Enqueue(v);
                }
            }
            if (nodes.All(x => g[x].Count == 2))
                cycle.Add(nodes.Count);
            else if (nodes.Count > 1)
                path.Add(nodes.Count);
        }

        static long GetScore(int l, int r, int isCycle)
        {
            long score = 0;
            long a = r, b = r;
            for (long i = r - 1; i >= l; i--)
            {
                score += a * i;
                a = b;
                b = i;
            }
            return score += a * b * isCycle;
        }
        long score = 0;
        foreach (var k in cycle)
        {
            score += GetScore(n - k + 1, n, 1);
            n -= k;
        }
        path = path.OrderBy(x => -x).ToList();
        foreach (var k in path)
        {
            score += GetScore(n - k + 1, n, 0);
            n -= k;
        }
        return score;
    }
}
