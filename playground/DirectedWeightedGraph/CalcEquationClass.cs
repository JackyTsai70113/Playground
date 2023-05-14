namespace playground.DirectedWeightedGraph;

public class CalcEquationClass
{
    /// <remarks>https://leetcode.com/problems/evaluate-division</remarks>
    public static double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var graph = new Dictionary<string, Dictionary<string, double>>();
        for (int i = 0; i < equations.Count; ++i)
        {
            if (!graph.ContainsKey(equations[i][0]))
            {
                graph[equations[i][0]] = new Dictionary<string, double>();
            }
            graph[equations[i][0]][equations[i][1]] = values[i];
            if (!graph.ContainsKey(equations[i][1]))
            {
                graph[equations[i][1]] = new Dictionary<string, double>();
            }
            graph[equations[i][1]][equations[i][0]] = 1 / values[i];
        }

        var res = new List<double>();
        HashSet<string> seen;
        foreach (var q in queries)
        {
            seen = new HashSet<string>();
            res.Add(GetPathWeight(graph, q[0], q[1], seen));
        }
        return res.ToArray();
    }

    private static double GetPathWeight(
        Dictionary<string, Dictionary<string, double>> graph,
        string start,
        string end,
        HashSet<string> seen)
    {
        if (!graph.ContainsKey(start) || !graph.ContainsKey(end) || seen.Contains(start))
        {
            return -1.0;
        }
        if (start == end)
        {
            return 1.0;
        }
        seen.Add(start);
        foreach(var nei in graph[start].Keys){
            var pathWeight = GetPathWeight(graph, nei, end, seen);
            if(pathWeight != -1.0){
                return graph[start][nei] * pathWeight;
            }
        }
        return -1.0;
    }
}