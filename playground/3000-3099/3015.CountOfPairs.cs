namespace playground;

public class CountOfPairs3015
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-houses-at-a-certain-distance-i
    /// </summary>
    public static int[] CountOfPairs(int n, int x, int y)
    {
        var res = new int[n];
        if (x == y)
        {
            for (int i = 0; i < n; ++i)
            {
                res[i] = (n - i - 1) * 2;
            }
            return res;
        }
        List<int>[] getGraph()
        {
            var g = new List<int>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                g[i] = new();
            }
            for (int i = 1; i <= n; ++i)
            {
                if (i - 1 >= 1)
                    g[i].Add(i - 1);
                if (i + 1 <= n)
                    g[i].Add(i + 1);
                if (i == x && i != y && y != i - 1 && y != i + 1)
                    g[i].Add(y);
                if (i == y && i != x && x != i - 1 && x != i + 1)
                    g[i].Add(x);
            }
            return g;
        }
        var g = getGraph();
        Queue<int> q = new();
        HashSet<int> seen = new();

        for (int i = 1; i <= n; ++i)
        {
            int step = 1;
            q.Clear();
            seen.Clear();
            q.Enqueue(i);
            seen.Add(i);
            while (q.Count > 0)
            {
                for (int j = q.Count; j > 0; --j)
                {
                    var u = q.Dequeue();
                    foreach (var v in g[u])
                    {
                        if (!seen.Contains(v))
                        {
                            res[step - 1]++;
                            q.Enqueue(v);
                            seen.Add(v);
                        }
                    }
                }
                step++;
            }
        }
        return res;
    }
}
