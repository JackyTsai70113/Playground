using System.Text;

namespace playground.Stacks;

public class DecodeAtIndexClass
{
    /// <summary>
    /// https://leetcode.com/problems/decoded-string-at-index
    /// </summary>
    public static string DecodeAtIndex(string s, int k)
    {
        int i;
        long K = k, N = 0;
        for (i = 0; N < K; ++i)
            N = char.IsDigit(s[i]) ? N * (s[i] - '0') : N + 1;
        for (i--; i > 0; i--)
        {
            if (char.IsDigit(s[i]))
            {
                N /= s[i] - '0';
                K %= N;
            }
            else
            {
                if (K % N == 0)
                    break;
                N--;
            }
        }
        return s[i].ToString();
    }
}
