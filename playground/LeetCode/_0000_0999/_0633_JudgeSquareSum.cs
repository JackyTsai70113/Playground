namespace playground.LeetCode._0000_0999;

public class _0633_JudgeSquareSum
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-square-numbers
    /// </summary>
    public static bool JudgeSquareSum(int c)
    {
        for (long i = 0; i * i <= c; i++)
        {
            if ((int)(Math.Sqrt(c - i * i)) == Math.Sqrt(c - i * i))
                return true;
        }
        return false;
    }

    public static bool JudgeSquareSum2(int c)
    {
        long l = 0, r = (long)Math.Sqrt(c);
        while (l <= r)
        {
            long sum = l * l + r * r;
            if (sum == c)
                return true;
            else if (sum < c)
                l++;
            else
                r--;
        }
        return false;
    }
}
