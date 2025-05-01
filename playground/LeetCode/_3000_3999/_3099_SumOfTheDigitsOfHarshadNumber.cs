namespace playground;

public class _3099_SumOfTheDigitsOfHarshadNumber
{
    /// <summary>
    /// https://leetcode.com/problems/harshad-number
    /// </summary>
    public static int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int sum = 0, y = x;
        while (y > 0)
        {
            sum += y % 10;
            y /= 10;
        }
        return x % sum == 0 ? sum : -1;
    }
}
