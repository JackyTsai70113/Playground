namespace playground;

public class FindMaximumNumber3007
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-that-sum-of-the-prices-is-less-than-or-equal-to-k
    /// </summary>
    public static long FindMaximumNumber(long k, int x)
    {
        long l = 0, r = 1L << 50;
        while (l < r)
        {
            long m = l + (r - l + 1) / 2;
            if (SumPrice(m, x) <= k)
                l = m;
            else
                r = m - 1;
        }
        return l - 1;
    }

    private static long SumPrice(long num, int x)
    {
        long price = 0;
        for (int i = x; (1L << (i - 1)) <= num; i += x)
        {
            long quotient = num / (1L << i) * (1L << (i - 1));
            long remainder = num % (1L << i) - (1L << (i - 1));
            if (remainder < 0) remainder = 0;
            price += quotient + remainder;
        }
        return price;
    }
}
