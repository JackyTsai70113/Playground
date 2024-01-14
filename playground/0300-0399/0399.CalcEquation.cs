namespace playground;

public class CalcEquation0399
{
    /// <summary>
    /// https://leetcode.com/problems/evaluate-division
    /// </summary>
    public static double[] CalcEquation(IList<IList<string>> eqs, double[] values, IList<IList<string>> queries)
    {
        Dictionary<string, Dictionary<string, double>> g = new();
        for (int i = 0; i < eqs.Count; i++)
        {
            string a = eqs[i][0], b = eqs[i][1];
            if (!g.ContainsKey(a)) g[a] = new();
            g[a][b] = values[i];
            if (!g.ContainsKey(b)) g[b] = new();
            g[b][a] = 1 / values[i];
        }
        double GetWeight(string start, string end, HashSet<string> seen)
        {
            if (!g.ContainsKey(start) || !g.ContainsKey(end) || seen.Contains(start))
                return -1.0;
            if (start == end)
                return 1.0;
            seen.Add(start);
            foreach (var nei in g[start].Keys)
            {
                var weight = GetWeight(nei, end, seen);
                if (weight != -1.0) return g[start][nei] * weight;
            }
            return -1;
        }
        HashSet<string> seen;
        var res = new double[queries.Count];
        for (int i = 0; i < queries.Count; i++)
        {
            seen = new();
            res[i] = GetWeight(queries[i][0], queries[i][1], seen);
        }
        return res;
    }
}
