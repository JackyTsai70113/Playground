namespace playground;

public class KnightDialer_0935
{
    public static int KnightDialer(int n)
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

    public static int KnightDialer2(int n)
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
