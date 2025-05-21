namespace playground.LeetCode._3000_3999;

public class _3337_LengthAfterTransformations
{
    public static int LengthAfterTransformations_TopDown(string s, int t, IList<int> nums)
    {
        long MOD = 1_000_000_007;
        var memo = new long[t + 1, 26];
        long dfs(int k, int c)
        {
            if (k == 0)
                return 1;
            if (memo[k, c] != 0)
                return memo[k, c];
            long res = 0;
            for (int i = 1; i <= nums[c]; i++)
            {
                res = (res + dfs(k - 1, (c + i) % 26)) % MOD;
            }
            return memo[k, c] = res;
        }
        long res = 0;
        foreach (var c in s)
        {
            res = (res + dfs(t, c - 'a')) % MOD;
        }
        return (int)res;
    }

    public static int LengthAfterTransformations_BottomUp(string s, int t, IList<int> nums)
    {
        long MOD = 1_000_000_007;
        var dp = new long[t + 1, 26];
        for (int i = 0; i < 26; i++)
            dp[0, i] = 1;
        for (int i = 1; i <= t; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                for (int k = 1; k <= nums[j]; k++)
                {
                    dp[i, j] = (dp[i, j] + dp[i - 1, (j + k) % 26]) % MOD;
                }
            }
        }
        long res = 0;
        foreach (var c in s)
        {
            res = (res + dp[t, c - 'a']) % MOD;
        }
        return (int)res;
    }

    public static int LengthAfterTransformations_OptimizeSpace(string s, int t, IList<int> nums)
    {
        long MOD = 1_000_000_007;
        var dp = Enumerable.Repeat((long)1, 26).ToArray();
        for (int i = 1; i <= t; i++)
        {
            var dp2 = new long[26];
            for (int j = 0; j < 26; j++)
            {
                for (int k = 1; k <= nums[j]; k++)
                {
                    dp2[j] = (dp2[j] + dp[(j + k) % 26]) % MOD;
                }
            }
            dp = dp2;
        }
        long res = 0;
        foreach (var c in s)
        {
            res = (res + dp[c - 'a']) % MOD;
        }
        return (int)res;
    }

    public static int LengthAfterTransformations_OptimizeSpace2(string s, int t, IList<int> nums)
    {
        long MOD = 1_000_000_007;
        var dp = Enumerable.Repeat((long)1, 26).ToArray();
        var prefixDp = new long[53];
        var dp2 = new long[26];
        for (int i = 1; i <= t; i++)
        {
            prefixDp[0] = 0;
            for (int j = 0; j < 52; j++)
            {
                prefixDp[j + 1] = (prefixDp[j] + dp[j % 26]) % MOD;
            }
            for (int j = 0; j < 26; j++)
            {
                dp2[j] = (prefixDp[j + nums[j] + 1] + MOD - prefixDp[j + 1]) % MOD;
            }
            (dp, dp2) = (dp2, dp);
        }
        long res = 0;
        foreach (var c in s)
        {
            res = (res + dp[c - 'a']) % MOD;
        }
        return (int)res;
    }

    private const int MOD = (int)1e9 + 7;
    private const int L = 26;

    private class Mat
    {
        public int[,] a = new int[L, L];

        public Mat() { }

        public Mat(Mat copyFrom)
        {
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    a[i, j] = copyFrom.a[i, j];
                }
            }
        }

        public Mat Mul(Mat other)
        {
            Mat result = new();
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    for (int k = 0; k < L; k++)
                    {
                        result.a[i, j] = (int)((result.a[i, j] + (long)a[i, k] * other.a[k, j]) % MOD);
                    }
                }
            }
            return result;
        }
    }
    /* identity matrix */
    private static Mat I()
    {
        Mat m = new Mat();
        for (int i = 0; i < L; i++)
        {
            m.a[i, i] = 1;
        }
        return m;
    }
    /* matrix exponentiation by squaring */
    private static Mat QuickMul(Mat x, int y)
    {
        Mat ans = I();
        Mat cur = new(x);
        while (y > 0)
        {
            if ((y & 1) == 1)
            {
                ans = ans.Mul(cur);
            }
            cur = cur.Mul(cur);
            y >>= 1;
        }
        return ans;
    }

    public static int LengthAfterTransformations_Matrix(string s, int t, IList<int> nums)
    {
        Mat T = new();
        for (int i = 0; i < L; i++)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                T.a[(i + j) % L, i] = 1;
            }
        }

        Mat res = QuickMul(T, t);
        int[] f = new int[L];
        foreach (char ch in s)
        {
            f[ch - 'a']++;
        }

        int ans = 0;
        for (int i = 0; i < L; i++)
        {
            for (int j = 0; j < L; j++)
            {
                ans = (int)((ans + (long)res.a[i, j] * f[j]) % MOD);
            }
        }
        return ans;
    }
}
