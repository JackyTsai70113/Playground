namespace playground.LeetCode._2000_2999;

public class _2925_MaximumScoreAfterOperations
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-score-after-applying-operations-on-a-tree
    /// </summary>
    public static long MaximumScoreAfterOperations(int[][] edges, int[] values)
    {
        var g = new List<int>[values.Length];
        for (int i = 0; i < values.Length; ++i)
            g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }

        (long invalid, long valid) dfs(int pa, int u)
        {
            long sumInvalid = 0, sumValid = -1;
            foreach (var v in g[u])
            {
                if (v != pa)
                {
                    var (aa, bb) = dfs(u, v);
                    sumInvalid += aa;
                    sumValid = sumValid == -1 ? bb : (sumValid + bb);
                }
            }
            return (values[u] + sumInvalid,
                    sumValid == -1 ? 0 : Math.Max(values[u] + sumValid, sumInvalid));
        }
        var (_, valid) = dfs(-1, 0);
        return valid;
    }
}
