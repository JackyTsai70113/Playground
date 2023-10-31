namespace playground.DynamicPrograming;

public class NumberOfWaysClass
{
    /// <summary>
    /// https://leetcode.com/problems/string-transformation
    /// </summary>
    /// <remarks>
    /// 矩陣連乘
    /// z-algoriothm
    /// </remarks>
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

        // z-algoriothm
        int[] z = new int[3 * n];
        string text = s + t + t;
        int l = 0, r = 0;
        for (int i = 1; i < n * 2; ++i)
        {
            if (i > r)
            {
                l = r = i;
                while (r < n * 3 && text[r - l] == text[r])
                    r++;
                z[i] = r - l;
                r--;
            }
            else
            {
                if (z[i - l] < r - i + 1)
                {
                    z[i] = z[i - l];
                }
                else
                {
                    l = i;
                    while (r < n * 3 && text[r - l] == text[r])
                        r++;
                    z[i] = r - l;
                    r--;
                }
            }
            if (i > n && i < n * 2 && z[i] >= n)
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
