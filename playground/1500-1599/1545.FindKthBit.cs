namespace playground;

public class FindKthBit1545
{
    /// <summary>
    /// https://leetcode.com/problems/find-kth-bit-in-nth-binary-string
    /// </summary>
    public static char FindKthBit(int n, int k)
    {
        if (n == 1) return '0';

        int middle = (int)Math.Pow(2, n - 1);

        if (k == middle)
        {
            return '1';
        }
        else if (k < middle)
        {
            return FindKthBit(n - 1, k);
        }
        else
        {
            var ch = FindKthBit(n - 1, 2 * middle - k);
            return ch == '0' ? '1' : '0';
        }
    }
}
