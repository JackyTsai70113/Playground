using System.Numerics;

namespace playground;

public class HammingWeight_0191
{
    public static int HammingWeight(uint n)
    {
        return BitOperations.PopCount(n);
    }

    public static int HammingWeight2(uint n)
    {
        int res = 0;
        while (n > 0)
        {
            n &= n - 1;
            res++;
        }
        return res;
    }

    public static int HammingWeight3(uint n)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            res += (int)(n & 1);
            n >>= 1;
        }
        return res;
    }
}
