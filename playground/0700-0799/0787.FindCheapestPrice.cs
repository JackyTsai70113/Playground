namespace playground;

public class FindCheapestPrice0787
{
    /// <summary>
    /// https://leetcode.com/problems/cheapest-flights-within-k-stops
    /// </summary>
    public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var g = new List<(int v, int p)>[n];
        foreach (var f in flights)
        {
            g[f[0]] ??= new();
            g[f[0]].Add((f[1], f[2]));
        }

        var stepsTo = new int[n];
        Array.Fill(stepsTo, int.MaxValue);

        var pq = new PriorityQueue<(int, int, int), int>();
        pq.Enqueue((src, 0, 0), 0);
        while (pq.Count > 0)
        {
            var (u, p, steps) = pq.Dequeue();
            if (steps > stepsTo[u] || steps > k + 1) continue;
            if (u == dst) return p;
            stepsTo[u] = steps;
            if (g[u] != null)
            {
                foreach (var (v, price) in g[u])
                {
                    pq.Enqueue((v, p + price, steps + 1), p + price);
                }
            }
        }
        return -1;
    }
}
