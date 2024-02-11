namespace playground;

public class SingleNumber0136
{
    /// <summary>
    /// https://leetcode.com/problems/single-number
    /// </summary>
    public static int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (var num in nums)
            res ^= num;
        return res;
    }
}
