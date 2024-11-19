namespace playground._0800_0899;

public class _851_LoudAndRich
{
    public static int[] LoudAndRich(int[][] richer, int[] quiet)
    {
        int n = quiet.Length;
        int[] inDegree = new int[n], res = new int[n];
        for (int i = 0; i < n; i++) res[i] = i;
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var r in richer)
        {
            inDegree[r[1]]++;
            g[r[0]].Add(r[1]);
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (inDegree[i] == 0)
                q.Enqueue(i);
        }
        while (q.Count > 0)
        {
            int u = q.Dequeue();
            foreach (var v in g[u])
            {
                inDegree[v]--;
                if (inDegree[v] == 0)
                    q.Enqueue(v);
                if (quiet[res[v]] > quiet[res[u]])
                    res[v] = res[u];
            }
        }
        return res;
    }
}
