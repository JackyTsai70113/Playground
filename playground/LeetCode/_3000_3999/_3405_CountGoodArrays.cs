using playground.Helpers;

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

        long MOD = 1_000_000_007;
        return (int)(MathHelper.GetCombination(n - 1, k, MOD) * m % MOD * MathHelper.Pow(m - 1, n - 1 - k, MOD) % MOD);
    }
}
