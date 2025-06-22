using playground.Helpers;

namespace playground.LeetCode._3000_3999;

public class _3310_RemainingMethods
{
    public static IList<int> RemainingMethods(int n, int k, int[][] invocations)
    {
        List<int>[] g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();

        var ds = new DisjointSet(n);
        foreach (var i in invocations)
        {
            int a = i[0], b = i[1];
            g[a].Add(b);
            ds.Union(a, b);
        }

        bool[] suspicious = new bool[n];
        int[] suspiciousCount = new int[n];

        void Dfs(int method)
        {
            if (suspicious[method]) return;
            suspicious[method] = true;
            var group = ds.Find(method);
            suspiciousCount[group]++;
            foreach (var next in g[method])
            {
                Dfs(next);
            }
        }

        Dfs(k);

        List<int> remainingMethods = new();
        for (int i = 0; i < n; i++)
        {
            var group = ds.Find(i);
            if (!suspicious[i] || suspiciousCount[group] != ds.ranks[group])
            {
                remainingMethods.Add(i);
            }
        }

        return remainingMethods;
    }
}
