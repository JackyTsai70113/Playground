namespace playground.DynamicProgramming;

public class MinExtraCharClass
{
    /// <summary>
    /// https://leetcode.com/problems/extra-characters-in-a-string
    /// </summary>
    public static int MinExtraChar(string str, string[] A)
    {
        var hs = A.ToHashSet();
        var memo = Enumerable.Repeat(-1, str.Length).ToArray();
        int dfs(int i)
        {
            if (i >= str.Length) return 0;
            if (memo[i] != -1) return memo[i];
            memo[i] = int.MaxValue;
            foreach (var s in hs)
            {
                if (i + s.Length - 1 < str.Length && str.Substring(i, s.Length) == s)
                {
                    memo[i] = Math.Min(memo[i], dfs(i + s.Length));
                }
            }
            memo[i] = Math.Min(memo[i], 1 + dfs(i + 1));
            return memo[i];
        }
        return dfs(0);
    }

    /// <summary>
    /// tabulation
    /// </summary>
    public static int MinExtraChar2(string s, string[] A)
    {
        int n = s.Length;
        var memo = new int[n + 1];
        Array.Fill(memo, n);
        for (int i = 1; i <= n; i++)
        {
            foreach (var a in A)
            {
                if (i >= a.Length
                    && s[(i - a.Length)..i] == a)
                    memo[i] = Math.Min(memo[i], memo[i - a.Length] - a.Length);
            }
            memo[i] = Math.Min(memo[i], memo[i - 1]);
        }
        return memo[n];
    }
}
