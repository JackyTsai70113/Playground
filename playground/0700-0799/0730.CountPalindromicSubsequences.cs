namespace playground;

public class CountPalindromicSubsequences0730
{
    /// <summary>
    /// https://leetcode.com/problems/count-different-palindromic-subsequences
    /// </summary>
    public static int CountPalindromicSubsequences(string s)
    {
        int n = s.Length, MOD = (int)1e9 + 7;
        var dp = new int[n, n];
        for (int i = 0; i < n; i++)
            dp[i, i] = 1;
        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i + len - 1 < n; i++)
            {
                int j = i + len - 1;
                int l = i + 1, r = j - 1;
                if (s[i] == s[j])
                {
                    while (l <= r && s[l] != s[j]) l++;
                    while (l <= r && s[i] != s[r]) r--;
                    if (l > r)
                        dp[i, j] = dp[i + 1, j - 1] * 2 + 2;
                    else if (l == r)
                        dp[i, j] = dp[i + 1, j - 1] * 2 + 1;
                    else
                        dp[i, j] = dp[i + 1, j - 1] * 2 - dp[l + 1, r - 1];
                }
                else
                {
                    dp[i, j] = dp[i + 1, j] + dp[i, j - 1] - dp[i + 1, j - 1];
                }
                dp[i, j] = dp[i, j] < 0 ? dp[i, j] + MOD : dp[i, j] % MOD;
            }
        }
        return dp[0, n - 1];
    }
}
