namespace playground;

public class KnightDialer_0935
{
    public static int KnightDialer(int n)
    {
        long MOD = (long)1e9 + 7;
        var dp = new Dictionary<(int, int, int), long>();
        var dirs = new int[][]{
            new int[]{2,1},
            new int[]{1,2},
            new int[]{-1,2},
            new int[]{-2,1},
            new int[]{-2,-1},
            new int[]{-1,-2},
            new int[]{1,-2},
            new int[]{2,-1},
        };
        long dfs(int[] pt, int cur)
        {
            if (cur == 1)
                return 1;
            if (dp.ContainsKey((pt[0], pt[1], cur)))
                return dp[(pt[0], pt[1], cur)];
            long res = 0;
            for (int i = 0; i < 8; ++i)
            {
                int x = pt[0] + dirs[i][0], y = pt[1] + dirs[i][1];
                if (x >= 0 && y >= 0 && x <= 2 && y <= 2 || x == 3 && y == 1)
                {
                    res = Add(res, dfs(new int[] { x, y }, cur - 1));
                }
            }
            return dp[(pt[0], pt[1], cur)] = res;
        }

        long Add(long x, long y)
        {
            return (x + y) % MOD;
        }

        long Mul(long x, long y)
        {
            return x * y % MOD;
        }
        long res = Mul(2, dfs(new int[] { 0, 0 }, n));
        res = Add(res, dfs(new int[] { 0, 1 }, n));
        res = Add(res, Mul(2, dfs(new int[] { 1, 0 }, n)));
        res = Add(res, dfs(new int[] { 1, 1 }, n));
        res = Add(res, Mul(2, dfs(new int[] { 2, 0 }, n)));
        res = Add(res, dfs(new int[] { 2, 1 }, n));
        res = Add(res, dfs(new int[] { 3, 1 }, n));
        return (int)res;
    }

    public static int KnightDialer2(int n)
    {
        long[] dp = new long[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        static long Add(long x, long y)
        {
            return (x + y) % (long)(1e9 + 7);
        }
        while (n-- > 1)
        {
            dp = new long[] {
                Add(dp[4], dp[6]),
                Add(dp[6], dp[8]),
                Add(dp[7], dp[9]),
                Add(dp[4], dp[8]),
                Add(Add(dp[0], dp[3]), dp[9]),
                0,
                Add(Add(dp[0], dp[1]), dp[7]),
                Add(dp[2], dp[6]),
                Add(dp[1], dp[3]),
                Add(dp[2], dp[4])
            };
        }
        long res = 0;
        foreach (var num in dp)
            res = Add(res, num);
        return (int)res;
    }

    public static int KnightDialer3(int n)
    {
        long MOD = (long)1e9 + 7;
        long Add(long x, long y)
        {
            return (x + y) % MOD;
        }

        long Mul(long x, long y)
        {
            return x * y % MOD;
        }

        long[,] Mul2(long[,] matrix1, long[,] matrix2)
        {
            int m1 = matrix1.GetLength(0), n1 = matrix1.GetLength(1);
            int m2 = matrix2.GetLength(0), n2 = matrix2.GetLength(1);
            var res = new long[m1, n2];
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    for (int k = 0; k < n2; k++)
                    {
                        res[i, k] = Add(res[i, k], Mul(matrix1[i, j], matrix2[j, k]));
                    }
                }
            }
            return res;
        }

        long[,] N = { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
        long[,] M = {
            { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
            { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
        };
        n--;
        while (n > 0)
        {
            if (n % 2 == 1) N = Mul2(N, M);
            M = Mul2(M, M);
            n /= 2;
        }
        long res = 0;
        foreach (var num in N)
            res = Add(res, num);
        return (int)res;
    }
}
