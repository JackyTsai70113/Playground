namespace playground;

public class MyPow0050
{
    /// <summary>
    /// https://leetcode.com/problems/powx-n
    /// </summary>
    public static double MyPow(double x, int n)
    {
        if (x == 0 || x == 1 || n == 1) return x;
        if (n == 0) return 1;
        var res = MyPow(x * x, n / 2);
        if (n < 0 && (-n) % 2 == 1)
            res *= 1 / x;
        else if (n > 0 && n % 2 == 1)
            res *= x;
        return res;
    }
}
