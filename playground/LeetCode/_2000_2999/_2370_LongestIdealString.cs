namespace playground.LeetCode._2000_2999;

public class _2370_LongestIdealString
{
    /// <summary>
    /// https://leetcode.com/problems/longest-ideal-subsequence
    /// </summary>
    public static int LongestIdealString(string s, int k)
    {
        int res = 0;
        var memo = new int[150];
        foreach (var c in s)
        {
            for (int i = c - k; i <= c + k; i++)
            {
                memo[c] = Math.Max(memo[c], memo[i]);
            }
            res = Math.Max(res, ++memo[c]);
        }
        return res;
    }
}
