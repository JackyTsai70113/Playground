namespace playground.LeetCode._0000_0999;

public class _0202_IsHappy
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number
    /// </summary>
    public static bool IsHappy(int n)
    {
        while (n > 9)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }
            n = sum;
        }
        return n == 1 || n == 7;
    }
}
