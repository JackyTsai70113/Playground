namespace playground.LeetCode._2000_2999;

public class _2101_MaximumDetonation
{
    /// <summary>
    /// https://leetcode.com/problems/detonate-the-maximum-bombs
    /// </summary>
    public static int MaximumDetonation(int[][] bombs)
    {
        int n = bombs.Length, res = 0;
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = new();
            for (int j = 0; j < n; j++)
            {
                var distPow2 =
                    Math.Pow(bombs[i][0] - bombs[j][0], 2) +
                    Math.Pow(bombs[i][1] - bombs[j][1], 2);
                if (Math.Pow(bombs[i][2], 2) >= distPow2)
                    graph[i].Add(j);
            }
        }
        bool[] seen;
        for (int i = 0; i < n; i++)
        {
            seen = new bool[n];
            res = Math.Max(res, Dfs(graph, i, seen));
        }
        return res;
    }

    static int Dfs(List<int>[] graph, int u, bool[] seen)
    {
        int res = 1;
        seen[u] = true;
        foreach (var v in graph[u])
        {
            if (seen[v]) continue;
            res += Dfs(graph, v, seen);
        }
        return res;
    }
}
