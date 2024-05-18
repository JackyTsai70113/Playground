using System.Numerics;

namespace playground;

public class FindProductsOfElements3145
{
    /// <summary>
    /// https://leetcode.com/problems/find-products-of-elements-of-big-array
    /// </summary>
    public int[] FindProductsOfElements(long[][] queries)
    {
        List<int> res = new();
        foreach (var q in queries)
        {
            long prefixSum1 = PrefixSumTillIndex(q[0]);
            long prefixSum2 = PrefixSumTillIndex(q[1] + 1);
            res.Add(Power(2, prefixSum2 - prefixSum1, q[2]));
        }
        return res.ToArray();
    }

    (long bitSum, long bitCount) SumAndCountBitsBeforeValue(long value)
    {
        long bitSum = 0, bitCount = 0;
        int bit = 0;
        for (long power = 1; power < value; bit++, power <<= 1)
        {
            long cur = (value >> (bit + 1)) << bit;
            cur += Math.Max(0, (value % (power << 1)) - power);
            bitCount += cur;
            bitSum += bit * cur;
        }
        return (bitSum, bitCount);
    }

    long GetValueFromIndex(long index)
    {
        index++;
        long l = 1, r = 1L << 50;
        while (l < r)
        {
            long m = l + (r - l) / 2;
            if (SumAndCountBitsBeforeValue(m + 1).bitCount < index)
                l = m + 1;
            else
                r = m;
        }
        return l;
    }

    long PrefixSumTillIndex(long index)
    {
        long value = GetValueFromIndex(index);
        var (bitSum, bitCount) = SumAndCountBitsBeforeValue(value);
        if (bitCount < index)
        {
            for (int bit = 0; bitCount < index; bit++, value >>= 1)
            {
                bitSum += bit * (value % 2);
                bitCount += value % 2;
            }
        }
        return bitSum;
    }
    /// <summary>
    /// (x ^ y) % mod
    /// </summary>
    int Power(long x, long y, long mod)
    {
        if (y <= 0)
            return (int)(1 % mod);
        long res = 1;
        while (y > 0)
        {
            if ((y & 1) > 0)
                res = res * x % mod;
            x = x * x % mod;
            y >>= 1;
        }
        return (int)res;
    }

    // long Count(long x, long[] memo)
    // {
    //     if (x == 0) return 0;
    //     var b = 64 - BitOperations.LeadingZeroCount((ulong)x) - 1;
    //     var v = 1 << b;
    //     var res = (long)b * (b - 1) * v >> 2;
    //     return res + Count(x - v, memo) + b * (x - v);
    // }

    /*
    1, 2, 1, 2, 4, 1, 4

    1: 1                 1*1
    2: 1 ,2              1*1, 2*1
    4: 1, 2, 1, 2, 4     (1*1 + 2*1) * 2 + (4-2)*2 - 2*2 + 4: (1*2+2*2+4)
       1  2  3     4     1 2 1 2 2 2(1*2+2*2+4)
    8: 1, 2, 1, 2, 4, 1, 4, 2, 4, 1, 2, 4, 8 (1*2+2*2+4) * 2 + (8-4)*4 - 4*2 + 8: 1122411224448
       1  2  3     4  5     6     7        8 (1*4+2*4+4*4+8)
    16: (1*4+2*4+4*4+8)*2 + (16-8)*8 - 8*2 + 16
        (1*4+2*4+4*4+8)*2 + (16-8)*8 - 8*2 + 16: 1*8+2*8+4*8+8*8+16
    */
}
