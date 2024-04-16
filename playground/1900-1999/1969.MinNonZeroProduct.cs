using System.Numerics;

namespace playground;

public class MinNonZeroProduct1969
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-non-zero-product-of-the-array-elements
    /// </summary>
    public static int MinNonZeroProduct(int p)
    {
        // (2^p-2)^(2^p/2-1)*(2^p-1)
        long MOD = (long)1e9 + 7, cur = (long)Math.Pow(2, p);
        var power = MyPower((cur - 2) % MOD, cur / 2 - 1, MOD);
        return (int)((cur - 1) % MOD * power % MOD);
    }

    private static long MyPower(long number, long power, long MOD)
    {
        if (power == 0) return 1;
        if (power == 1) return number;
        // power are always odd
        return MyPower(number * number % MOD, power / 2, MOD) * number % MOD;
    }

    public static int MinNonZeroProduct2(int p)
    {
        long MOD = (long)1e9 + 7, val = (1L << p) - 1;
        return (int)(val % MOD * BigInteger.ModPow(val - 1, val / 2, MOD) % MOD);
    }
}