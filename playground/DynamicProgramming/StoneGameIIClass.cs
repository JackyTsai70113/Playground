namespace playground.DynamicProgramming;

public class StoneGameIIClass
{
    /// <remarks>https://leetcode.com/problems/stone-game-ii</remarks>
    public static int StoneGameII(int[] piles)
    {
        int n = piles.Length;
        var presum = piles.ToArray();
        for (int i = n - 2; i >= 0; --i) presum[i] += presum[i + 1];
        var memo = new int[n, n];
        int dfs(int i, int m)
        {
            if (i + 2 * m >= n) return presum[i];
            if (memo[i, m] != 0) return memo[i, m];
            int min = int.MaxValue;
            for (int j = 1; j <= 2 * m; ++j)
                min = Math.Min(min, dfs(i + j, Math.Max(m, j)));
            return memo[i, m] = presum[i] - min;
        }
        return dfs(0, 1);
    }
}
