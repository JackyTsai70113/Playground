namespace playground.LeetCode._2000_2999;

public class _2457_MakeIntegerBeautiful
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-addition-to-make-integer-beautiful
    /// </summary>
    public static long MakeIntegerBeautiful(long n, int target)
    {
        long ba = 1, n0 = n;
        while (n.ToString().Select(x => x - '0').Sum() > target)
        {
            n = n / 10 + 1;
            ba *= 10;
        }
        return n * ba - n0;
    }
}
