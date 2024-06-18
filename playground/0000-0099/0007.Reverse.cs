namespace playground;

public class Reverse0007
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer
    /// </summary>
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
