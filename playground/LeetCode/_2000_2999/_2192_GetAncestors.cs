namespace playground.LeetCode._2000_2999;

public class _2192_GetAncestors
{
    /// <summary>
    /// https://leetcode.com/problems/all-ancestors-of-a-node-in-a-directed-acyclic-graph
    /// </summary>
    public static IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++)
            g[i] = new();
        var indegrees = new int[n];
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            indegrees[e[1]]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
            if (indegrees[i] == 0)
                q.Enqueue(i);
        var res = new List<IList<int>>();
        for (int i = 0; i < n; i++)
            res.Add(new List<int>());
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            foreach (var v in g[u])
            {
                foreach (var x in res[u])
                    if (!res[v].Contains(x))
                        res[v].Add(x);
                res[v].Add(u);
                if (--indegrees[v] == 0)
                    q.Enqueue(v);
            }
        }
        for (int i = 0; i < n; i++)
            res[i] = res[i].OrderBy(x => x).ToList();
        return res;
    }
}
