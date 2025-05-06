namespace playground.LeetCode._2000_2999;

public class _2894_DifferenceOfSums
{
    public static int DifferenceOfSums(int n, int m)
    {
        var res = 0;
        for (int i = 1; i <= n; ++i)
        {
            if (i % m == 0)
                res -= i;
            else
                res += i;
        }
        return res;
    }
}
