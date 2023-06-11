namespace playground.Arrays;

public class MinCostClass
{
    /// <summary>
    /// https://leetcode.com/problems/collecting-chocolates
    /// </summary>
    public static long MinCost(int[] nums, int x)
    {
        int n = nums.Length;
        long res = long.MaxValue;
        var min = nums.ToArray();
        for (int rotate = 0; rotate < n; ++rotate)
        {
            long sum = (long)rotate * x;
            for (int i = 0; i < n; ++i)
            {
                min[i] = Math.Min(min[i], nums[(i + rotate) % n]);
                sum += min[i];
            }
            res = Math.Min(res, sum);
        }
        return res;
    }
}
