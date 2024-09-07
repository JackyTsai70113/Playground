namespace playground;

public class MaxScore3276
{
    public static int MaxScore(IList<IList<int>> A)
    {
        int m = A.Count, n = A[0].Count;

        Dictionary<int, List<int>> dict = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!dict.ContainsKey(A[i][j]))
                    dict[A[i][j]] = new();
                dict[A[i][j]].Add(i);
            }
        }

        List<int> vals = dict.Keys.OrderBy(x => -x).ToList();
        var dp = new int[1 << 11][];
        for (int i = 0; i < (1 << 11); i++)
            dp[i] = Enumerable.Repeat(-1, 101).ToArray();
        return Solve(0, vals, dict, 0, dp);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    /// <param name="vals">val list</param>
    /// <param name="dict">val, rowIndex</param>
    /// <param name="mask"></param>
    /// <param name="dp"></param>
    /// <returns></returns>
    public static int Solve(int i, List<int> vals, Dictionary<int, List<int>> dict, int mask, int[][] dp)
    {
        if (i == vals.Count) return 0;
        if (dp[mask][i] != -1)
            return dp[mask][i];
        int ans = 0;
        foreach (var index in dict[vals[i]])
        {
            if ((mask & (1 << index)) == 0)
            {
                ans = Math.Max(ans, vals[i] + Solve(i + 1, vals, dict, mask | (1 << index), dp));
            }
        }
        ans = Math.Max(ans, Solve(i + 1, vals, dict, mask, dp));
        return dp[mask][i] = ans;
    }
}
