namespace playground.LeetCode._3000_3999;

public class _3216_GetSmallestString
{
    public static string GetSmallestString(string s)
    {
        var res = s.ToCharArray();
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] % 2 == s[i + 1] % 2 && s[i] > s[i + 1])
            {
                (res[i], res[i + 1]) = (res[i + 1], res[i]);
                break;
            }
        }
        return new string(res);
    }
}
