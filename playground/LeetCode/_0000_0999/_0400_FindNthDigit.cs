namespace playground.LeetCode._0000_0999;

public class _0400_FindNthDigit
{
    /// <summary>
    /// https://leetcode.com/problems/nth-digit
    /// </summary>
    public static int FindNthDigit(int n)
    {
        int w = 0;
        while (n > 9 * (Math.Pow(10, w)) * (w + 1))
        {
            n -= 9 * (int)Math.Pow(10, w) * (w + 1);
            w++;
        }
        n--;
        int x = n / (w + 1), y = n % (w + 1);
        int z = (int)Math.Pow(10, w) + x;
        return z.ToString()[y] - '0';
    }

    public static int FindNthDigit2(int n)
    {
        long width = 1, baseNumber = 1;
        while (n > width * 9 * baseNumber)
        {
            n -= (int)(width * 9 * baseNumber);
            width++;
            baseNumber *= 10;
        }
        var str = ((n - 1) / (int)width + baseNumber).ToString();
        return str[(n - 1) % (int)width] - '0';
    }
}
