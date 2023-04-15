namespace playground.DirectedGraph;

public class DirectedGraphTemplateClass
{
    public static int[] DirectedGraphTemplate(int[][] edges)
    {
        var graph = new Dictionary<int, HashSet<int>>();
        foreach (var e in edges)
        {
            if (!graph.ContainsKey(e[0])) graph[e[0]] = new HashSet<int>();
            graph[e[0]].Add(e[1]);
            if (!graph.ContainsKey(e[1])) graph[e[1]] = new HashSet<int>();
            graph[e[1]].Add(e[0]);
        }

        var res = new List<int>();
        var seen = new HashSet<int>();
        void dfs(int i)
        {
            res.Add(i);
            foreach (var nei in graph[i])
            {
                if (seen.Contains(nei)) continue;
                seen.Add(nei);
                dfs(nei);
            }
            res.Add(i);
        }
        int first = graph.Keys.First();
        seen.Add(first);
        dfs(first);
        return res.ToArray();
    }
}