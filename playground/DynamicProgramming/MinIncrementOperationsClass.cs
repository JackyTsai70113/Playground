namespace playground.DynamicProgramming;

public class MinIncrementOperationsClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-increment-operations-to-make-array-beautiful
    /// </summary>
    public static long MinIncrementOperations(int[] nums, int k)
    {
        long res = 0;
        var memo = new long[3];
        for (int i = 0; i < nums.Length; ++i)
        {
            long a = Math.Max(0, k - nums[i]);
            if (i >= 3) a += res;
            (memo[0], memo[1], memo[2]) = (memo[1], memo[2], a);
            res = memo.Min();
        }
        return res;
    }
}
