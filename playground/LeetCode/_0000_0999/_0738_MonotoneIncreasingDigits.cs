using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0738_MonotoneIncreasingDigits
{
    /// <summary>
    /// https://leetcode.com/problems/monotone-increasing-digits
    /// </summary>
    public static int MonotoneIncreasingDigits(int n)
    {
        StringBuilder sb = new(n.ToString());
        for (int i = sb.Length - 1; i > 0; i--)
        {
            if (sb[i - 1] > sb[i])
            {
                sb[i - 1] = (char)(sb[i - 1] - 1);
                for (int j = i; j < sb.Length; j++)
                {
                    sb[j] = '9';
                }
            }
        }
        return int.Parse(sb.ToString());
    }
}
