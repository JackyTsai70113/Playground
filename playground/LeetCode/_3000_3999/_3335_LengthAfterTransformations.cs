using System.Threading.Tasks.Dataflow;

namespace playground.LeetCode._3000_3999;

public class _3335_LengthAfterTransformations
{
    public static int LengthAfterTransformations_TopDown(string s, int t)
    {
        var dp = new long[26, t + 1];
        long res = 0, MOD = (long)1e9 + 7;
        long dfs(int c, int k)
        {
            if (dp[c, k] != 0)
                return dp[c, k];
            if (k + c >= 26)
            {
                dp[c, k] = (dfs(0, k + c - 26) + dfs(1, k + c - 26)) % MOD;
            }
            else
            {
                dp[c, k] = 1;
            }
            return dp[c, k];
        }
        foreach (var c in s)
        {
            res = (res + dfs(c - 'a', t)) % MOD;
        }
        return (int)res;
    }

    public static int LengthAfterTransformations_BottomUp(string s, int t)
    {
        long res = 0, MOD = (long)1e9 + 7;
        var dp = new long[t + 1, 26];
        for (int i = 0; i < Math.Min(t + 1, 26); i++)
        {
            for (int j = 0; i + j < 26; j++)
            {
                dp[i, j] = 1;
            }
        }
        for (int i = 1; i < t + 1; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (j == 25)
                    dp[i, j] = (dp[i - 1, 0] + dp[i - 1, 1]) % MOD;
                else
                    dp[i, j] = dp[i - 1, j + 1];
            }
        }
        foreach (var c in s)
        {
            res = (res + dp[t, c - 'a']) % MOD;
        }
        return (int)res;
    }

    public static int LengthAfterTransformations_OptimizeSpace(string s, int t)
    {
        int res = 0, MOD = (int)1e9 + 7;
        var dp = new int[26];
        Array.Fill(dp, 1);
        for (int i = 0; i < t; i++)
        {
            var dp2 = new int[26];
            for (int j = 0; j < 26; j++)
            {
                if (j == 25)
                    dp2[j] = (dp[0] + dp[1]) % MOD;
                else
                    dp2[j] = dp[j + 1];
            }
            dp = dp2.ToArray();
        }
        foreach (var c in s)
        {
            res = (res + dp[c - 'a']) % MOD;
        }
        return res;
    }
}
