using playground.Algorithms;

namespace playground.LeetCode._2000_2999;

public class _2851_NumberOfWays
{
    public static int NumberOfWays(string s, string t, long k)
    {
        var chs = new int[26];
        for (int i = 0; i < s.Length; ++i)
        {
            chs[s[i] - 'a']++;
            chs[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; ++i)
            if (chs[i] != 0)
                return 0;

        int n = s.Length, MOD = (int)(1e9 + 7), res = 0;
        k %= MOD - 1;
        var dp = new long[][] {
            new long[] { 0, 1 },
            new long[] { n - 1, n - 2 }
        };
        dp = Pow(dp, k, MOD);
        long a0 = dp[0][0], a1 = dp[0][1];

        string text = s + t + t;
        int[] z = ZAlgorithm.ZFunction(text);
        for (int i = n + 1; i < n * 2; i++)
        {
            if (z[i] >= n)
            {
                res = (res + (int)a1) % MOD;
            }
        }
        if (s == t)
        {
            res = (res + (int)a0) % MOD;
        }
        return res;
    }

    static long[][] Mul(long[][] a, long[][] b, int MOD)
    {
        int m = a.Length, n = a[0].Length, p = b[0].Length;
        var res = new long[m][];
        for (int i = 0; i < m; ++i)
        {
            res[i] = new long[p];
        }
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                for (int k = 0; k < p; ++k)
                {
                    res[i][k] = (res[i][k] + a[i][j] * b[j][k]) % MOD;
                }
            }
        }
        return res;
    }

    static long[][] Pow(long[][] a, long k, int MOD)
    {
        int n = a.Length;
        var res = new long[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new long[n];
            res[i][i] = 1;
        }
        for (; k > 0; k >>= 1)
        {
            if ((k & 1) > 0)
            {
                res = Mul(res, a, MOD);
            }
            a = Mul(a, a, MOD);
        }
        return res;
    }
}
