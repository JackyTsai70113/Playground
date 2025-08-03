namespace playground.LeetCode._3000_3999;

public class _3614_ProcessStr
{
    public static char ProcessStr(string s, long k)
    {
        long currentLength = 0;

        foreach (char charS in s)
        {
            if (char.IsLetter(charS))
            {
                currentLength++;
            }
            else if (charS == '*')
            {
                if (currentLength > 0)
                {
                    currentLength--;
                }
            }
            else if (charS == '#')
            {
                currentLength *= 2;
            }
        }

        if (k >= currentLength)
        {
            return '.';
        }

        char res = 'a';
        for (int i = s.Length - 1; i >= 0; i--)
        {
            char c = s[i];

            if (char.IsLetter(c))
            {
                currentLength--;
                if (k == currentLength)
                {
                    res = c;
                }
                if (k > currentLength)
                {
                    k--;
                }
            }
            else if (c == '*')
            {
                currentLength++;
            }
            else if (c == '#')
            {
                currentLength /= 2;
                if (k >= currentLength)
                {
                    k -= currentLength;
                }
            }
            else if (c == '%')
            {
                k = currentLength - 1 - k;
            }
        }

        return res;
    }
}
