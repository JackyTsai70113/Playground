using System.Numerics;

namespace playground.LeetCode._3000_3999;

public class _3566_CheckEqualPartitions
{
    public static bool CheckEqualPartitions(int[] nums, long target)
    {
        BigInteger totalProduct = 1;
        foreach (var num in nums)
        {
            if (target % num != 0)
                return false;
            totalProduct *= num;
        }

        return totalProduct / target == target;
    }
}
