namespace playground.DynamicProgramming;

public class MinIncrementsClass
{
    /// <remarks>https://leetcode.com/problems/make-costs-of-paths-equal-in-a-binary-tree/</remarks>
    public static int MinIncrements(int n, int[] cost)
    {
        var res = 0;
        for (int i = n - 1; i > 0; i -= 2)
        {
            int max = Math.Max(cost[i - 1], cost[i]);
            res += max * 2 - cost[i - 1] - cost[i];
            cost[(i >> 1) - 1] += max;
        }
        return res;
    }
}
