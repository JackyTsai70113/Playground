using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0151_ReverseWords
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string
    /// </summary>
    public static string ReverseWords(string s)
    {
        var ss = s.Split(' ').Where(x => x != string.Empty).ToList();
        var sb = new StringBuilder();
        for (int i = ss.Count - 1; i >= 0; --i)
        {
            sb.Append(ss[i]);
            if (i > 0)
                sb.Append(' ');
        }
        return sb.ToString();
    }
}
