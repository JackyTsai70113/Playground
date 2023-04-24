namespace playground.DirectedWeightedGraph;

public class DirectedWeightedGraphTemplateClass
{
    public static int[] DirectedWeightedGraphTemplate(int[][] edges)
    {
        var graph = new Dictionary<int, HashSet<(int n, int w)>>();
        foreach (var e in edges)
        {
            if (!graph.ContainsKey(e[0])) graph[e[0]] = new HashSet<(int, int)>();
            graph[e[0]].Add((e[1], e[2]));
        }

        var res = new List<int>();
        var seen = new HashSet<int>();
        void dfs(int i)
        {
            if (!graph.ContainsKey(i)) return;
            foreach (var (n, w) in graph[i])
            {
                if (seen.Contains(n)) continue;
                seen.Add(n);
                dfs(n);
            }
        }
        int first = graph.Keys.First();
        seen.Add(first);
        dfs(first);

        //2 BFS 找最小遍歷時會用，依分群後的 node 遍歷
        return res.ToArray();
    }
}