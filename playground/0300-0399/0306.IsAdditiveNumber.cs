namespace playground;

public class IsAdditiveNumber0306
{
    /// <summary>
    /// https://leetcode.com/problems/additive-number
    /// </summary>
    public static bool IsAdditiveNumber(string num)
    {
        for (int i = 1; i <= num.Length / 2; ++i)
        {
            for (int j = 1; j <= (num.Length - i) / 2; ++j)
            {
                var first = num[..i];
                var second = num.Substring(i, j);
                var third = num[(i + j)..];
                if (Bt(first, second, third))
                    return true;
            }
        }
        return false;
    }

    static bool Bt(string first, string second, string third)
    {
        if (first.Length > 1 && first[0] == '0' ||
            second.Length > 1 && second[0] == '0')
            return false;
        string sum = (long.Parse(first) + long.Parse(second)).ToString();
        if (sum == third) return true;
        if (third.Length <= sum.Length || sum != third[..sum.Length])
            return false;
        return Bt(second, third[..sum.Length], third[sum.Length..]);
    }
}
