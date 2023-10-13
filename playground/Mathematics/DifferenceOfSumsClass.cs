namespace playground;

public class DifferenceOfSumsClass
{
    /// <summary>
    /// https://leetcode.com/problems/divisible-and-non-divisible-sums-difference
    /// </summary>
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
