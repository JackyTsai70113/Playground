namespace playground.LeetCode._3000_3999;

public class _3560_MinCuttingCost
{
    public static long MinCuttingCost(int n, int m, int k)
    {
        long cost = 0;
        if (n > k)
        {
            cost += (long)k * (n - k);
        }

        if (m > k)
        {
            cost += (long)k * (m - k);
        }

        return cost;
    }
}
