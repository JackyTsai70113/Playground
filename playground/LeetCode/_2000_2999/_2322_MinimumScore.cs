namespace playground.LeetCode._2000_2999;

public class _2322_MinimumScore
{
    public static int MinimumScore(int[] nums, int[][] edges)
    {
        int n = nums.Length;
        int V = 0, res = int.MaxValue;
        var g = new List<int>[n];
        var degrees = new int[n];

        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
            degrees[e[0]]++;
            degrees[e[1]]++;
        }

        var q = new Queue<int>();
        var seen = new bool[n];
        for (int i = 0; i < n; i++)
        {
            V ^= nums[i];
            if (degrees[i] == 1)
            {
                q.Enqueue(i);
                degrees[i]--;
            }
        }

        var xors = new int[n];
        var children = new HashSet<int>[n];
        for (int i = 0; i < n; i++) children[i] = new();
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            xors[u] ^= nums[u];
            foreach (var v in g[u])
            {
                if (degrees[v] > 1)
                {
                    xors[v] ^= xors[u];
                    children[v].UnionWith(children[u]);
                    children[v].Add(u);
                    degrees[v]--;
                    if (degrees[v] == 1)
                    {
                        q.Enqueue(v);
                    }
                }
            }
        }

        for (int i = 0; i < edges.Length - 1; i++)
        {
            for (int j = i + 1; j < edges.Length; j++)
            {
                int a = edges[i][0], b = edges[i][1];
                int c = edges[j][0], d = edges[j][1];
                // set a is child of b
                if (children[a].Contains(b)) (a, b) = (b, a);

                // set c is child of d
                if (children[c].Contains(d)) (c, d) = (d, c);

                List<int> vals;
                if (children[a].Contains(c))
                    vals = new List<int> { V ^ xors[a], xors[a] ^ xors[c], xors[c] };
                else if (children[c].Contains(a))
                    vals = new List<int> { V ^ xors[c], xors[c] ^ xors[a], xors[a] };
                else
                    vals = new List<int> { V ^ xors[a] ^ xors[c], xors[a], xors[c] };
                res = Math.Min(res, vals.Max() - vals.Min());
            }
        }
        return res;
    }
}
