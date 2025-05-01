namespace playground;

public class _3133_MinEnd
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-array-end
    /// </summary>
    public static long MinEnd(int n, int x)
    {
        n--;
        long res = x;
        for (long i = 1; n > 0; i <<= 1)
        {
            if ((res & i) == 0)
            {
                res |= i * (n & 1);
                n >>= 1;
            }
        }
        return res;
    }
}
