namespace playground.LeetCode._2000_2999;

public class _2872_MaxKDivisibleComponents
{
    public static int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        if (n == 1) return 1;
        List<int>[] graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new();
        int[] outDegrees = new int[n];
        long[] vals = values.Select(v => (long)v).ToArray();
        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
            outDegrees[edge[0]]++;
            outDegrees[edge[1]]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (outDegrees[i] == 1)
                q.Enqueue(i);
        }
        var res = 0;
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            outDegrees[node]--;
            if (vals[node] % k == 0)
            {
                res++;
            }
            foreach (var nei in graph[node])
            {
                if (outDegrees[nei] > 0)
                {
                    if (vals[node] % k != 0)
                    {
                        vals[nei] += vals[node];
                    }
                    outDegrees[nei]--;
                    if (outDegrees[nei] == 1)
                    {
                        q.Enqueue(nei);
                    }
                }
            }
        }
        return res;
    }
}
