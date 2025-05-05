namespace playground.LeetCode._3000_3999;

public class _3448_CountSubstrings
{
    public static long CountSubstrings(string s)
    {
        int n = s.Length;
        long res = 0;

        int mod3 = 0, mod9 = 0, prefix7 = 0;
        int[] freq3 = new int[3], freq9 = new int[9], freq7 = new int[7];
        freq3[0] = freq9[0] = freq7[0] = 1;

        var inverse_modulo_7 = new int[] { 1, 5, 4, 6, 2, 3 };

        for (int i = 0; i < n; i++)
        {
            int digit = s[i] - '0';
            mod3 = (mod3 + digit) % 3;
            mod9 = (mod9 + digit) % 9;

            prefix7 = (prefix7 * 10 + digit) % 7;
            int norm7 = prefix7 * inverse_modulo_7[(i + 1) % 6] % 7;

            res += CountDivisibleSubstrings(s, i, digit, mod3, mod9, norm7, freq3, freq9, freq7);

            freq3[mod3]++;
            freq9[mod9]++;
            freq7[norm7]++;
        }

        return res;
    }

    private static long CountDivisibleSubstrings(string s, int i, int digit, int mod3, int mod9, int norm7,
        int[] freq3, int[] freq9, int[] freq7)
    {
        long count = 0;

        if (digit == 1 || digit == 2 || digit == 5)
        {
            count += i + 1;
        }
        else if (digit == 4)
        {
            count++; // 單位數 4
            if (i >= 1 && IsDivisibleBy(s, i - 1, 2, 4)) // 後兩位被 4 整除
                count += i;
        }
        else if (digit == 8)
        {
            count++; // 單位數 8
            if (i >= 1 && IsDivisibleBy(s, i - 1, 2, 8))
                count++;
            if (i >= 2 && IsDivisibleBy(s, i - 2, 3, 8))
                count += i - 1;
        }
        else if (digit == 3 || digit == 6)
        {
            count += freq3[mod3];
        }
        else if (digit == 9)
        {
            count += freq9[mod9];
        }
        else if (digit == 7)
        {
            count += freq7[norm7];
        }

        return count;
    }

    private static bool IsDivisibleBy(string s, int startIndex, int length, int divisor)
    {
        string segment = s.Substring(startIndex, length);
        return int.Parse(segment) % divisor == 0;
    }
}
