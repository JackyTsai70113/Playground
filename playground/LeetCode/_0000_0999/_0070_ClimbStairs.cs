namespace playground.LeetCode._0000_0999;

public class _0070_ClimbStairs
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs
    /// </summary>
    public static int ClimbStairs(int n)
    {
        int pre = 0, cur = 1;
        for (int i = 0; i < n; i++)
            (pre, cur) = (cur, pre + cur);
        return cur;
    }
}
