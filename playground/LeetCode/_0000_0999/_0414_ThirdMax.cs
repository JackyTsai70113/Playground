namespace playground.LeetCode._0000_0999;

public class _0414_ThirdMax
{
    /// <summary>
    /// https://leetcode.com/problems/third-maximum-number
    /// </summary>
    public static int ThirdMax(int[] nums)
    {
        int? a = nums[0], b = null, c = null;
        foreach (var x in nums)
        {
            if (x == a || x == b || x == c)
                continue;
            if (x > a)
                (a, b, c) = (x, a, b);
            else if (b == null)
                (b, c) = (x, b);
            else if (x > b)
                (b, c) = (x, b);
            else if (c == null)
                c = x;
            else if (x >= c)
                c = x;
        }
        return c == null ? a.Value : c.Value;
    }
}
