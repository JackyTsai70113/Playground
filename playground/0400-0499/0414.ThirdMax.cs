namespace playground;

public class ThirdMax_0414
{
    /// <summary>
    /// https://leetcode.com/problems/third-maximum-number
    /// </summary>
    public static int ThirdMax(int[] nums)
    {
        int? a = null, b = null, c = null;
        foreach (var x in nums)
        {
            if (x == a || x == b || x == c)
                continue;
            if (a == null || x > a)
                (a, b, c) = (x, a, b);
            else if (b == null || x > b)
                (b, c) = (x, b);
            else if (c == null || x >= c)
                c = x;
        }
        return c == null ? a.Value : c.Value;
    }
}
