namespace playground._3400_3499;

public class _3419_MinMaxWeight
{
    public static int MinMaxWeight(int n, int[][] edges, int threshold)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        HashSet<int> weightSet = new();
        foreach (var e in edges)
        {
            g[e[1]].Add(e[0]);
            weightSet.Add(e[2]);
        }
        var weights = weightSet.ToArray();
        Array.Sort(weights);
        if (!CanVisitAll(n, g))
            return -1;
        int l = 0, r = weights.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            int W = weights[m];
            var cur = new List<int>[n];
            for (int i = 0; i < n; i++) cur[i] = new();
            foreach (var e in edges)
            {
                if (e[2] <= W)
                    cur[e[1]].Add(e[0]);
            }
            if (CanVisitAll(n, cur))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return weights[l];
    }

    static bool CanVisitAll(int n, List<int>[] g)
    {
        var q = new Queue<int>();
        q.Enqueue(0);
        var seen = new HashSet<int>();
        seen.Add(0);
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var v in g[u])
            {
                if (!seen.Contains(v))
                {
                    seen.Add(v);
                    q.Enqueue(v);
                }
            }
        }
        return seen.Count == n;
    }
}
