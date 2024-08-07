namespace playground;

public class MinBitFlips2220
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
