using System.Numerics;

namespace playground._3400_3499;

public class _3448_CountSubstrings
{
    public static long CountSubstrings(string s)
    {
        int n = s.Length;
        long res = 0;
        int mod3 = 0, mod9 = 0, prefix7 = 0;
        int[] freq3 = new int[3], freq9 = new int[9], freq7 = new int[7];
        freq3[0] = freq9[0] = freq7[0] = 1;

        // 10^k mod 7 的逆元
        // Since 10 mod 7 = 3 and the powers of 3 modulo 7 cycle every 6:
        //   3^0 = 1, 3^1 = 3, 3^2 = 2, 3^3 = 6, 3^4 = 4, 3^5 = 5, 3^6 = 1, ...
        // Their inverses modulo 7 are:
        //   1 -> 1, 3 -> 5, 2 -> 4, 6 -> 6, 4 -> 2, 5 -> 3.
        var inverses_modulo_7 = new int[] { 1, 5, 4, 6, 2, 3 };

        for (int i = 0; i < n; i++)
        {
            int lastDigit = s[i] - '0';
            mod3 = (mod3 + lastDigit) % 3;
            mod9 = (mod9 + lastDigit) % 9;

            prefix7 = (prefix7 * 10 + lastDigit) % 7;
            int norm7 = (prefix7 * inverses_modulo_7[i % 6]) % 7;

            if (lastDigit == 1 || lastDigit == 2 || lastDigit == 5)
            {
                res += i + 1;
            }
            else if (lastDigit == 4)
            {
                res++;
                if (i > 0 && int.Parse(s.Substring(i - 1, 2)) % 4 == 0)
                {
                    res += i;
                }
            }
            else if (lastDigit == 8)
            {
                res++;
                if (i >= 1 && int.Parse(s.Substring(i - 1, 2)) % 8 == 0)
                {
                    res++;
                }
                if (i >= 2 && int.Parse(s.Substring(i - 2, 3)) % 8 == 0)
                {
                    res += i - 1;
                }
            }
            else if (lastDigit == 3 || lastDigit == 6)
            {
                res += freq3[mod3];
            }
            else if (lastDigit == 9)
            {
                res += freq9[mod9];
            }
            else if (lastDigit == 7)
            {
                res += freq7[norm7];
            }
            freq3[mod3]++;
            freq9[mod9]++;
            freq7[norm7]++;
        }

        return res;
    }
}
