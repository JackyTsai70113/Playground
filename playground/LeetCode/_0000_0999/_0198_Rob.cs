namespace playground.LeetCode._0000_0999;

public class _0198_Rob
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber
    /// </summary>
    public static int Rob(int[] nums)
    {
        int rob = 0, notRob = 0;
        foreach (var num in nums)
            (rob, notRob) = (notRob + num, Math.Max(rob, notRob));
        return Math.Max(rob, notRob);
    }
}
