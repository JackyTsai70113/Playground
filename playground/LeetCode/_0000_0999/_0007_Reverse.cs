namespace playground.LeetCode._0000_0999;

public class _0007_Reverse
{
    public static int Reverse(int x)
    {
        int res = 0;
        while (x != 0)
        {
            if (res > int.MaxValue / 10 || res < int.MinValue / 10)
                return 0;
            res = res * 10 + x % 10;
            x /= 10;
        }
        return res;
    }
}
