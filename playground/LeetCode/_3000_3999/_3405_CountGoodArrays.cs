namespace playground.LeetCode._3000_3999;

public class _3405_CountGoodArrays
{
    public static int CountGoodArrays(int n, int m, int k)
    {
        // n=3, m=2, k=1
        // n-1's good array: 01, 10
        //   total k count of 1, n-1-k count of 0
        //   , 0 means not same, 1 means same
        // (n-1)!/k!/(n-1-k)!

        // assign each value of good array:
        //     0-index: m
        //     next if num == 1: count for 1
        //     next if num == 0: count for m-1
        // m * (m-1) ^ n-1-k

        long Pow(long val, long exp, long mod)
        {
            long res = 1;
            val %= mod;
            while (exp > 0)
            {
                if ((exp & 1) == 1)
                    res = res * val % mod;
                val = val * val % mod;
                exp >>= 1;
            }
            return res;
        }

        long ModInverse(long n, long mod)
        {
            return Pow(n, mod - 2, mod);
        }

        long Comb(int n, int r, long mod)
        {
            // if (r < 0 || r > n) return 0;
            if (r == 0 || r == n) return 1;
            if (r > n - r) r = n - r;

            long numerator = 1;
            for (int i = 0; i < r; i++)
                numerator = numerator * (n - i) % mod;
            long denominator = 1;
            for (int i = 1; i <= r; i++)
                denominator = denominator * i % mod;
            return numerator * ModInverse(denominator, mod) % mod;
        }

        long MOD = 1_000_000_007;
        return (int)(Comb(n - 1, k, MOD) * m % MOD * Pow(m - 1, n - 1 - k, MOD) % MOD);
    }
}
