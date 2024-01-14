namespace playground;

public class NumberOfPowerfulInt2999
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-powerful-integers
    /// </summary>
    public static long NumberOfPowerfulInt(long start, long finish, int limit, string s)
    {
        return LessThan(finish, s, limit) - LessThan(start - 1, s, limit);
    }

    public static long LessThan(long num, string s, int limit)
    {
        var str = num.ToString();
        if (str.Length < s.Length || str.Length == s.Length && num < long.Parse(s))
        {
            return 0;
        }

        long res = 1, element = (long)Math.Pow(10, s.Length);
        if (num % element >= long.Parse(s))
        {
            num = num / element;
        }
        else
        {
            num = num / element - 1;
        }
        str = num.ToString();
        for (int i = 0; i < str.Length; ++i)
        {
            var cur = str[i] - '0';
            if (cur > limit)
            {
                res += (long)Math.Pow(limit + 1, str.Length - i) - 1;
                break;
            }
            else
            {
                res += cur * (long)Math.Pow(limit + 1, str.Length - 1 - i);
            }
        }
        return res;
    }
}
