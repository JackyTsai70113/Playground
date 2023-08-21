namespace playground.UndirectedGraph;

public class IsPossibleClass
{
    /// <remarks>https://leetcode.com/problems/add-edges-to-make-degrees-of-all-nodes-even</remarks>
    public static bool IsPossible(int n, IList<IList<int>> edges)
    {
        var g = Enumerable.Range(0, n).Select(i => new HashSet<int>()).ToList();
        foreach (var e in edges)
        {
            g[e[0] - 1].Add(e[1] - 1);
            g[e[1] - 1].Add(e[0] - 1);
        }
        var oddEdges = g.Select((u, i) => i).Where(i => g[i].Count % 2 == 1).ToList();

        if (oddEdges.Count == 2)
        {
            var (a, b) = (oddEdges[0], oddEdges[1]);
            return g.Any(vSet => !vSet.Contains(a) && !vSet.Contains(b));
        }
        else if (oddEdges.Count == 4)
        {
            var (a, b, c, d) = (oddEdges[0], oddEdges[1], oddEdges[2], oddEdges[3]);
            bool areConnect(int a, int b)
            {
                return g[a].Contains(b);
            }
            return !areConnect(a, b) && !areConnect(c, d)
                || !areConnect(a, c) && !areConnect(b, d)
                || !areConnect(a, d) && !areConnect(b, c);
        }
        return oddEdges.Count == 0;
    }
}
