using System.Text;

namespace playground.LeetCode._2000_2999;

public class _2081_KMirror
{
    public static long KMirror(int k, int n)
    {
        long res = 0;
        // 1, 2, 3, ..., 9, 10, 11, 12, ..., 99, 100, ...
        for (int len = 1; n > 0; len *= 10)
        {
            for (long i = len; n > 0 && i < len * 10; i++)
            {
            Console.WriteLine();
                long cur = CreatePalindrome(i, true);
                if (IsPalindrome(cur, k))
                {
                    res += cur;
                    n--;
                }
            }

            for (long i = len; n > 0 && i < len * 10; i++)
            {
                long cur = CreatePalindrome(i, false);
                if (IsPalindrome(cur, k))
                {
                    res += cur;
                    n--;
                }
            }
        }
        return res;
    }

    static long CreatePalindrome(long num, bool odd)
    {
        long x = num;
        if (odd) x /= 10;
        while (x > 0)
        {
            num = num * 10 + x % 10;
            x /= 10;
        }
        return num;
    }

    public static bool IsPalindrome(long num, int k)
    {
        var sb = new StringBuilder();
        while (num > 0)
        {
            sb.Append((char)(num % k + '0'));
            num /= k;
        }
        int l = 0, r = sb.Length - 1;
        while (l < r)
        {
            if (sb[l++] != sb[r--])
                return false;
        }
        return true;
    }
}
