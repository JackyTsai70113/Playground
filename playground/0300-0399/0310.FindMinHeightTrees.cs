namespace playground;
public class FindMinHeightTrees0310
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-height-trees
    /// </summary>
    public static IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1) return new List<int> { 0 };
        var g = Graph.BuildUG(n, edges);
        var outDegree = new int[n];
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            outDegree[i] = g[i].Count;
            if (outDegree[i] == 1)
                q.Enqueue(i);
        }
        var res = new List<int>();
        while (q.Count > 0)
        {
            res = q.ToList();
            for (int i = q.Count - 1; i >= 0; i--)
            {
                var u = q.Dequeue();
                outDegree[u]--;
                foreach (var v in g[u])
                {
                    if (outDegree[v] > 0 && --outDegree[v] == 1)
                        q.Enqueue(v);
                }
            }
        }
        return res;
    }
}