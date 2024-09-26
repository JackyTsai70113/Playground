using System.Numerics;

namespace playground._2700_2799;

public class _2749_MakeTheIntegerZero
{
    public static int MakeTheIntegerZero(int num1, int num2)
    {
        for(int i = 1; i <= 60; i++){
            long target = (long)num1 - (long)num2 * i;
            if(BitOperations.PopCount((ulong)target) <= i && i <= target)
                return i;
        }
        return -1;
    }
}
