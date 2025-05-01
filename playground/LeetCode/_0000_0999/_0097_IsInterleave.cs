namespace playground.LeetCode._0000_0999;

public class _0097_IsInterleave
{
    /// <summary>
    /// https://leetcode.com/problems/interleaving-string
    /// </summary>
    public static bool IsInterleave(string s1, string s2, string s3)
    {
        int n1 = s1.Length, n2 = s2.Length;
        if (n1 + n2 != s3.Length)
            return false;
        var memo = new bool?[n1 + 1, n2 + 1];
        bool dp(int i, int j)
        {
            if (i == s1.Length && j == s2.Length)
            {
                return true;
            }
            if (memo[i, j].HasValue)
            {
                return memo[i, j].Value;
            }
            memo[i, j] = false;
            if (i < n1 && s1[i] == s3[i + j] && dp(i + 1, j))
            {
                memo[i, j] = true;
            }
            else if (j < n2 && s2[j] == s3[i + j] && dp(i, j + 1))
            {
                memo[i, j] = true;
            }
            return memo[i, j].Value;
        }
        return dp(0, 0);
    }
}
