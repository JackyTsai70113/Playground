namespace playground;

public class LongestIdealString2370
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
