namespace playground;

public class DecodeAtIndex0880
{
    /// <summary>
    /// https://leetcode.com/problems/decoded-string-at-index
    /// </summary>
    public static string DecodeAtIndex(string s, int k)
    {
        long N = 0, K = k;
        int i;
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
