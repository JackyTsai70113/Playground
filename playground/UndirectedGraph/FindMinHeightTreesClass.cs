namespace playground.UndirectedGraph;
public class FindMinHeightTreesClass
{
    public static IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
            return new List<int> { 0 };
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        var degrees = new int[n];
        var q = new Queue<int>();
        for (int i = 0; i < n; ++i)
        {
            degrees[i] = graph[i].Count;
            if (degrees[i] == 1)
            {
                q.Enqueue(i);
            }
        }

        var res = new List<int>();
        while (q.Count > 0)
        {
            res = new List<int>();
            while (q.Count > 0)
            {
                res.Add(q.Dequeue());
            }
            foreach (var node in res)
            {
                degrees[node]--;
                foreach (var nei in graph[node])
                {
                    degrees[nei]--;
                    if (degrees[nei] == 1)
                    {
                        q.Enqueue(nei);
                    }
                }
            }
        }
        return res;
    }
}