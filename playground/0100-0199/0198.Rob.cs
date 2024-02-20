namespace playground;

public class Rob0198
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
