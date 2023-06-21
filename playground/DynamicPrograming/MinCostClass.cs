namespace playground.DynamicPrograming;

public class MinCostClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-cut-a-stick
    /// </summary>
    public static int MinCost(int n, int[] cuts)
    {
        cuts = cuts.Append(0).Append(n).OrderBy(c => c).ToArray();
        int m = cuts.Length;
        int[,] memo = new int[m, m];
        int dfs(int l, int r)
        {
            if (r - l <= 1) return 0;
            if (memo[l, r] != 0) return memo[l, r];
            memo[l, r] = int.MaxValue;
            for (int i = l + 1; i <= r - 1; ++i)
                memo[l, r] = Math.Min(memo[l, r], cuts[r] - cuts[l] + dfs(l, i) + dfs(i, r));
            return memo[l, r];
        }
        return dfs(0, m - 1);
    }

    /// <remarks>和上面是同邏輯，由此 func 可以看出此演算法為 O(m^3), O(m^2)</remarks>
    public static int MinCost_2(int n, int[] cuts)
    {
        cuts = cuts.Append(0).Append(n).OrderBy(c => c).ToArray();
        int m = cuts.Length;
        int[,] memo = new int[m, m];
        for (int l = m - 1; l >= 0; --l)
            for (int r = l + 1; r < m; ++r)
                for (int i = l + 1; i <= r - 1; ++i)
                    memo[l, r] = Math.Min(memo[l, r] == 0 ? int.MaxValue : memo[l, r], cuts[r] - cuts[l] + memo[l, i] + memo[i, r]);
        return memo[0, m - 1];
    }
}