using System.Diagnostics.CodeAnalysis;

namespace playground.Strings;

public class IsNumberClass
{
    public static bool IsNumber(string s)
    {
        s = s.ToLower();
        int eIdx = s.IndexOf('e');
        if (eIdx == -1)
        {
            return IsValidDecimal(s, 0, s.Length - 1);
        }
        else
        {
            return IsValidDecimal(s, 0, eIdx - 1) && eIdx + 1 <= s.Length - 1 && IsValidInteger(s, eIdx + 1, s.Length - 1);
        }
    }

    static bool IsValidDecimal(string s, int l, int r)
    {
        if (s[l] == '-' || s[l] == '+')
            l++;
        return r >= l && IsValidDecimalWithoutSign(s, l, r);
    }

    static bool IsValidDecimalWithoutSign(string s, int l, int r)
    {

        int pointIdx = s.IndexOf('.', l, r - l + 1);
        if (pointIdx == -1)
        {
            return r >= l && IsValidIntegerWithoutSign(s, l, r);
        }
        else
        {
            var firstValid = pointIdx - 1 >= l && IsValidIntegerWithoutSign(s, l, pointIdx - 1);
            var secondValid = r >= pointIdx + 1 && IsValidIntegerWithoutSign(s, pointIdx + 1, r);
            return firstValid && pointIdx == r || pointIdx == l && secondValid || firstValid && secondValid;
        }
    }

    static bool IsValidInteger(string s, int l, int r)
    {
        if (s[l] == '-' || s[l] == '+')
            l++;
        return r >= l && IsValidIntegerWithoutSign(s, l, r);
    }

    static bool IsValidIntegerWithoutSign(string s, int l, int r)
    {
        for (int i = l; i <= r; ++i)
        {
            if (!char.IsDigit(s[i]))
                return false;
        }
        return true;
    }
}