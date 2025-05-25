namespace playground.LeetCode._3000_3999;

public class _3558_AssignEdgeWeights
{
    public static int AssignEdgeWeights(int[][] edges)
    {
        int n = edges.Length + 1;
        var g = new List<int>[n + 1];
        for (int i = 0; i <= n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        int depth = 0;
        var q = new Queue<(int par, int u)>();
        q.Enqueue((0, 1));
        while (q.Count > 0)
        {
            depth++;
            for (int i = q.Count; i > 0; i--)
            {
                var (par, u) = q.Dequeue();
                foreach (var v in g[u])
                {
                    if (v != par)
                    {
                        q.Enqueue((u, v));
                    }
                }
            }
        }

        depth--;
        long MOD = (long)1e9 + 7;
        long odd = 1, even = 1;
        for (int i = 1; i < depth; i++)
        {
            long next = (odd + even) % MOD;
            (odd, even) = (next, next);
        }
        return (int)odd;
    }
}
