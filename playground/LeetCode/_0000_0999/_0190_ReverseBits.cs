namespace playground.LeetCode._0000_0999;

public class _0190_ReverseBits
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-bits
    /// </summary>
    public static uint ReverseBits(uint n)
    {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            res += (n & 1) << (31 - i);
            n >>= 1;
        }
        return res;
    }
}
