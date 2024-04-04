namespace playground;

public class MaxDepth1614
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
    /// </summary>
    public static int MaxDepth(string s)
    {
        int res = 0, cur = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                cur++;
                res = Math.Max(res, cur);
            }
            else if (c == ')')
            {
                cur--;
            }
        }
        return res;
    }
}
