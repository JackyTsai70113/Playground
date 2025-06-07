namespace playground;

public class _1137_Tribonacci
{
    public static int Tribonacci(int n)
    {
        if (n < 2) return n;
        int a1 = 0, a2 = 0, a3 = 1;
        for (int i = 2; i <= n; ++i)
        {
            (a1, a2, a3) = (a2, a3, a1 + a2 + a3);
        }
        return a3;
    }
}
