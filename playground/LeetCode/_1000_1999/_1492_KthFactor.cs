namespace playground.LeetCode._1000_1999;

public class _1492_KthFactor
{
    public static int KthFactor(int n, int k)
    {
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                k--;
            if (k == 0)
                return i;
        }
        return -1;
    }
}
