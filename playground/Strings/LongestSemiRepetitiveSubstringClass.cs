namespace playground.Strings;

public class LongestSemiRepetitiveSubstringClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-longest-semi-repetitive-substring
    /// </summary>
    public static int LongestSemiRepetitiveSubstring(string s)
    {
        int l = 0, r = 1, res = 0, count = 0;
        for (; r < s.Length; ++r)
        {
            if (s[r - 1] == s[r])
            {
                count++;
                while (count > 1)
                {
                    if (s[l] == s[l + 1])
                    {
                        count--;
                    }
                    l++;
                }
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
