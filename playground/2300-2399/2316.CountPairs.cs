namespace playground;

public class CountPairs2316
{
    /// <summary>
    /// https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph
    /// </summary>
    public static long CountPairs(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        long res = 0, last = 0;
        var q = new Queue<int>();

        var seen = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (seen[i]) continue;
            q.Enqueue(i);
            seen[i] = true;
            int cur = 1;
            while (q.Count > 0)
            {
                var u = q.Dequeue();
                foreach (var v in g[u])
                {
                    if (seen[v]) continue;
                    seen[v] = true;
                    cur++;
                    q.Enqueue(v);
                }
            }
            res += last * cur;
            last += cur;
        }
        return res;
    }
}
