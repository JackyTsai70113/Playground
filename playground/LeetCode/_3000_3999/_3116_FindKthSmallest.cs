namespace playground;

public class _3116_FindKthSmallest
{
    /// <summary>
    /// https://leetcode.com/problems/kth-smallest-amount-with-single-denomination-combination
    /// </summary>
    public static long FindKthSmallest(int[] coins, int k)
    {
        long l = 1, r = long.MaxValue;
        while (l < r)
        {
            var m = l + (r - l) / 2;
            if (Count(coins, m) >= k)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    /// <summary>
    /// 不大於 k 的 coins 的倍數個數
    /// </summary>
    /// <remarks>Inclusion-Exclusion Principle</remarks>
    private static long Count(int[] coins, long max)
    {
        long gcd(long x, long y)
        {
            return y == 0 ? x : gcd(y, x % y);
        }
        long lcm(long x, long y)
        {
            return x * y / gcd(x, y);
        }
        long res = 0;
        for (int mask = 1; mask < (1 << coins.Length); mask++)
        {
            int bit = 0;
            long curLcm = 1;
            for (int i = 0; i < coins.Length; i++)
            {
                if (((mask >> i) & 1) > 0)
                {
                    bit++;
                    curLcm = lcm(curLcm, coins[i]);
                    if (curLcm > max) break;
                }
            }
            res += bit % 2 == 1 ? max / curLcm : -max / curLcm;
        }
        return res;
    }
}
