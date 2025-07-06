namespace playground.DynamicProgramming;

public class StoneGameIIIClass
{
    /// <remarks>https://leetcode.com/problems/stone-game-iii</remarks>
    public static string StoneGameIII(int[] stoneValue)
    {
        int n = stoneValue.Length; int[] memo = new int[3];
        var presum = stoneValue.ToArray();
        for (int i = n - 2; i >= 0; --i) presum[i] += presum[i + 1];
        for (int i = n - 1; i >= 0; --i)
        {
            int cur = int.MinValue;
            for (int j = 1; j <= memo.Length && i + j < n; ++j)
                cur = Math.Max(cur, presum[i] - presum[i + j] - memo[(i + j) % memo.Length]);
            if (i + memo.Length >= n)
                cur = Math.Max(cur, presum[i]);
            memo[i % memo.Length] = cur;
        }
        if (memo[0] > 0) return "Alice";
        if (memo[0] < 0) return "Bob";
        return "Tie";
    }

    /// <remarks>Tabulation version: O(n) / O(n)</remarks>
    public static string StoneGameIII_Tabulation(int[] stoneValue)
    {
        int n = stoneValue.Length;
        var presum = stoneValue.ToArray();
        for (int i = n - 2; i >= 0; --i) presum[i] += presum[i + 1];
        var memo = Enumerable.Repeat(int.MinValue, n).ToArray();
        for (int i = n - 1; i >= 0; --i)
        {
            for (int j = 1; j <= 3 && i + j < n; ++j)
                memo[i] = Math.Max(memo[i], presum[i] - presum[i + j] - memo[i + j]);
            if (i + 3 >= n)
                memo[i] = Math.Max(memo[i], presum[i]);
        }
        if (memo[0] > 0)
            return "Alice";
        else if (memo[0] == 0)
            return "Tie";
        else
            return "Bob";
    }

    /// <remarks>Tabulation version: O(n) / O(1)</remarks>
    public static string StoneGameIII_Tabulation_O1(int[] stoneValue)
    {
        int n = stoneValue.Length; int[] memo = new int[3];
        var presum = stoneValue.ToArray();
        for (int i = n - 2; i >= 0; --i) presum[i] += presum[i + 1];
        for (int i = n - 1; i >= 0; --i)
        {
            int cur = int.MinValue;
            for (int j = 1; j <= memo.Length && i + j < n; ++j)
            {
                cur = Math.Max(cur, presum[i] - presum[i + j] - memo[(i + j) % memo.Length]);
            }
            if (i + memo.Length >= n)
                cur = Math.Max(cur, presum[i]);
            memo[i % memo.Length] = cur;
        }
        if (memo[0] > 0)
            return "Alice";
        else if (memo[0] == 0)
            return "Tie";
        else
            return "Bob";
    }
}
