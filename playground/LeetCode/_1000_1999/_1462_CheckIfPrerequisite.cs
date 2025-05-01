namespace playground._1400_1499;

public class _1462_CheckIfPrerequisite_cs
{
    public static IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        var inDegree = new int[n];
        foreach (var p in prerequisites)
        {
            g[p[0]].Add(p[1]);
            inDegree[p[1]]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (inDegree[i] == 0)
                q.Enqueue(i);
        }
        var sets = new HashSet<int>[n];
        for (int i = 0; i < n; i++) sets[i] = new();
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var v in g[u])
            {
                foreach (var node in sets[u])
                    sets[v].Add(node);
                sets[v].Add(u);
                inDegree[v]--;
                if (inDegree[v] == 0)
                    q.Enqueue(v);
            }
        }
        var res = new bool[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            res[i] = sets[queries[i][1]].Contains(queries[i][0]);
        }
        return res;
    }
}
