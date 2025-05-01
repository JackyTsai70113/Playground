using System.Numerics;

namespace playground.LeetCode._2000_2999;

public class _2997_MinOperations
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-xor-equal-to-k
    /// </summary>
    public static int MinOperations(int[] nums, int k)
    {
        foreach (var num in nums)
        {
            k ^= num;
        }
        return BitOperations.PopCount((uint)k);
    }
}
