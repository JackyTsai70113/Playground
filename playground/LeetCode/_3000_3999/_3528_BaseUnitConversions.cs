namespace playground.LeetCode._3000_3999;

public class _3528_BaseUnitConversions
{
    public static int[] BaseUnitConversions(int[][] conversions)
    {
        int n = conversions.Length + 1;
        var g = new List<(int, int)>[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = new();
        }
        foreach (var c in conversions)
        {
            g[c[0]].Add((c[1], c[2]));
            g[c[1]].Add((c[0], c[2]));
        }

        var q = new Queue<int>();
        q.Enqueue(0);
        var res = new long[n];
        res[0] = 1;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var (v, factor) in g[u])
            {
                if (res[v] == 0)
                {
                    res[v] = res[u] * factor % (long)(1e9 + 7);
                    q.Enqueue(v);
                }
            }
        }
        return res.Select(x => (int)(x)).ToArray();
    }
}
