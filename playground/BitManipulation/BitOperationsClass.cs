using System.Numerics;

namespace playground.BitManipulation;

public class BitOperationsClass
{
    public static int PopCount(int num){
        return BitOperations.PopCount((uint)num);
    }
}
