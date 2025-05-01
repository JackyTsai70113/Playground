namespace playground.LeetCode._0000_0999;

public class _0557_ReverseWords
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string-iii
    /// </summary>
    public static string ReverseWords(string s)
    {
        var res = new char[s.Length];
        for (int l = 0, r = 0; r <= s.Length; ++r)
        {
            if (r == s.Length || s[r] == ' ')
            {
                if (r < s.Length)
                    res[r] = ' ';
                for (int i = l; i < r; ++i)
                {
                    res[i] = s[r - 1 + l - i];
                }
                l = r + 1;
            }
        }
        return new string(res);
    }
}
