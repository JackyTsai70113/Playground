namespace playground.LeetCode._2000_2999;

public class _2220_MinBitFlips
{
    public static int MinBitFlips(int start, int goal)
    {
        int res = 0, xo = start ^ goal;
        while (xo != 0)
        {
            res++;
            xo &= xo - 1;
        }
        return res;
    }
}
