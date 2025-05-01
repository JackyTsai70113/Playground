namespace playground.LeetCode._2000_2999;

public class _2929_DistributeCandies
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-candies-among-children-ii
    /// </summary>
    public static long DistributeCandies(int n, int limit)
    {
        long res = 0;
        for (int i = 0; i <= Math.Min(n, limit); ++i)
        {
            if (n - i <= Math.Min(n - i, limit) * 2)
            {
                res += Math.Min(n - i, limit) * 2 - (n - i) + 1;
            }
        }
        return res;
    }
}
