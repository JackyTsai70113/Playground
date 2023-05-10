using System.Numerics;

namespace playground.BitManipulation;

public class BitManipulationTemplateClass
{
    public static int GetBitCount(int i)
    {
        return BitOperations.PopCount((uint)i);
    }
}
