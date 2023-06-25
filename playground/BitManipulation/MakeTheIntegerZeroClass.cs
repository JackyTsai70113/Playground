using System.Numerics;

namespace playground.BitManipulation;

public class MakeTheIntegerZeroClass
{
    public static int MakeTheIntegerZero(int num1, int num2)
    {
        for (int i = 1; i <= 60; ++i)
        {
            if (num1 - num2 * i < 0)
                break;
            var v = num1 - num2 * i;
            int min = BitOperations.PopCount((uint)v);
            if (min <= i && i <= v)
            {
                return i;
            }
        }
        return -1;
    }
}
