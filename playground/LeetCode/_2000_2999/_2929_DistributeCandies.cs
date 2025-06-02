namespace playground.LeetCode._2000_2999;

public class _2929_DistributeCandies
{
    public static long DistributeCandies(int n, int limit)
    {
        if (n > limit * 3) return 0;
        long res = 0;
        static long Comb(int n) // 2 from n
        {
            if (n < 2) return 0;
            return (long)n * (n - 1) / 2;
        }
        res = Comb(n + 2) -
            3 * Comb(n + 2 - (limit + 1)) +
            3 * Comb(n + 2 - 2 * (limit + 1)) -
            Comb(n + 2 - 3 * (limit + 1));
        return res;
    }
}
