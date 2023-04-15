namespace playground.DirectedGraph;

public class LargestPathValueClass
{
    /// <remarks>https://leetcode.com/problems/largest-color-value-in-a-directed-graph</remarks>
    public static int LargestPathValue(string colors, int[][] edges)
    {
        int n = colors.Length;
        var graph = new List<int>[n];
        var indegrees = new int[n];
        foreach (var e in edges)
        {
            if (e[0] == e[1])
            {
                return -1;
            }
            if (graph[e[0]] == null)
            {
                graph[e[0]] = new();
            }
            graph[e[0]].Add(e[1]);
            indegrees[e[1]]++;
        }
        var zeroIndegrees = new Queue<int>();
        for (int i = 0; i < n; ++i)
        {
            if (indegrees[i] == 0)
                zeroIndegrees.Enqueue(i);
        }
        var counts = new int[n, 26];
        for (int i = 0; i < colors.Length; ++i)
        {
            counts[i, colors[i] - 'a']++;
        }

        int maxCount = 0;
        int visited = 0;
        while (zeroIndegrees.Count > 0)
        {
            var node = zeroIndegrees.Dequeue();
            visited++;
            if (graph[node] != null)
            {
                foreach (var nei in graph[node])
                {
                    for (int i = 0; i < 26; ++i)
                    {
                        counts[nei, i] = Math.Max(
                            counts[nei, i],
                            counts[node, i] + (colors[nei] - 'a' == i ? 1 : 0));
                    }
                    indegrees[nei]--;
                    if (indegrees[nei] == 0)
                    {
                        zeroIndegrees.Enqueue(nei);
                    }
                }
            }
            for (int i = 0; i < 26; ++i)
            {
                maxCount = Math.Max(maxCount, counts[node, i]);
            }
        }
        return visited == n ? maxCount : -1;
    }
}
