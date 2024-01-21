namespace playground;

public class Rob0198
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber
    /// </summary>
    public static int Rob(int[] nums)
    {
        int wi = 0, wo = 0;
        foreach (var num in nums)
            (wi, wo) = (Math.Max(wi, wo + num), wi);
        return Math.Max(wi, wo);
    }
}
