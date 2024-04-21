namespace playground;

public class ValidPath1971
{
    /// <summary>
    /// https://leetcode.com/problems/find-if-path-exists-in-graph
    /// </summary>
    public static bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        var q = new Queue<int>();
        var seen = new bool[n];
        q.Enqueue(source);
        seen[source] = true;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            if (u == destination) return true;
            foreach (var v in g[u])
            {
                if (seen[v]) continue;
                seen[v] = true;
                q.Enqueue(v);
            }
        }
        return false;
    }
}
