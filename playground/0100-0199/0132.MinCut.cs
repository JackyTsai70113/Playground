namespace playground;

public class MinCut0132
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-partitioning-ii
    /// </summary>
    public static int MinCut(string s)
    {
        if (s.Length <= 1) return 0;
        int n = s.Length;
        var memo = new int[n + 1];
        for (int i = 0; i <= n; i++) memo[i] = i - 1;
        for (int mid = 0; mid < n; mid++)
        {
            // even
            for (int len = 1; mid - len + 1 >= 0 && mid + len < n && s[mid - len + 1] == s[mid + len]; len++)
            {
                memo[mid + len + 1] = Math.Min(memo[mid + len + 1], 1 + memo[mid - len + 1]);
            }

            // odd
            for (int len = 0; mid - len >= 0 && mid + len < n && s[mid - len] == s[mid + len]; len++)
            {
                memo[mid + len + 1] = Math.Min(memo[mid + len + 1], 1 + memo[mid - len]);
            }
        }
        return memo[^1];
    }

    public static int MinCut2(string s)
    {
        return Dfs(s, 0, new int[s.Length]);
    }

    static int Dfs(string s, int start, int[] memo)
    {
        if (memo[start] != 0)
            return memo[start];
        memo[start] = int.MaxValue;
        if (IsPalindrome(s, start, s.Length - 1))
            return memo[start] = 0;
        for (int i = start; i < s.Length - 1; i++)
        {
            if (IsPalindrome(s, start, i))
            {
                memo[start] = Math.Min(memo[start], 1 + Dfs(s, i + 1, memo));
            }
        }
        return memo[start];
    }

    static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }
        return true;
    }
}
