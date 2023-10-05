namespace playground.Strings;

public class ReverseWordsClass
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string-iii
    /// </summary>
    public static string ReverseWords(string s)
    {
        var res = new char[s.Length];
        int l = 0;
        for (int r = 0; r < s.Length; ++r)
        {
            if (s[r] == ' ')
            {
                res[r] = ' ';
                for (int i = l; i < r; ++i)
                {
                    res[i] = s[r - 1 + l - i];
                }
                l = r + 1;
            }
        }
        for (int i = l; i < s.Length; ++i)
        {
            res[i] = s[s.Length - 1 + l - i];
        }
        return new string(res);
    }
}
