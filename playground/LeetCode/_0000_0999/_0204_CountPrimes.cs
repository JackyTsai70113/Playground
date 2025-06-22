using playground.Helpers;

namespace playground.LeetCode._0000_0999;

public class _0204_CountPrimes
{
    public static int CountPrimes(int n)
    {
        if (n == 2) return 0;
        var count = n / 2;
        var isPrime = MathHelper.GetPrimesSieve(n - 1);
        return isPrime.Count(x => x);
    }
}
