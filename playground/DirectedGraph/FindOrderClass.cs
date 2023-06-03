namespace playground.DirectedGraph;

public class FindOrderClass
{
    /// <summary>
    /// https://leetcode.com/problems/course-schedule-ii
    /// </summary>
    public static int[] FindOrder(int n, int[][] prerequisites)
    {
        var res = new List<int>();
        var graph = new List<int>[n];
        var indegrees = new int[n];
        foreach (var p in prerequisites)
        {
            if (graph[p[1]] == null) graph[p[1]] = new List<int>();
            graph[p[1]].Add(p[0]);
            indegrees[p[0]]++;
        }

        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (indegrees[i] == 0)
            {
                q.Enqueue(i);
            }
        }

        while (q.Count > 0)
        {
            var node = q.Dequeue();
            res.Add(node);
            if (graph[node] == null)
                continue;
            foreach (var nei in graph[node])
            {
                indegrees[nei]--;
                if (indegrees[nei] == 0)
                {
                    q.Enqueue(nei);
                }
            }
        }

        return res.Count == n ? res.ToArray() : Array.Empty<int>();
    }
}
