namespace playground.LeetCode._0000_0999;

public class _0139_WordBreak
{
    /// <summary>
    /// https://leetcode.com/problems/word-break
    /// </summary>
    public static bool WordBreak(string s, IList<string> wordDict)
    {
        var wordSet = wordDict.ToHashSet();
        var memo = new int[s.Length];
        bool dp(int start)
        {
            if (start == s.Length)
                return true;
            if (memo[start] != 0)
                return memo[start] == 1;
            memo[start] = 2;
            for (int len = 1; len <= s.Length - start; len++)
            {
                if (wordSet.Contains(s.Substring(start, len)) &&
                    dp(start + len))
                {
                    memo[start] = 1;
                    break;
                }
            }
            return memo[start] == 1;
        }
        return dp(0);
    }
}
