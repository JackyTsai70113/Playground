namespace playground;

public class ClimbStairs0070
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
