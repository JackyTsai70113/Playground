using System.Text;

namespace playground;

public class ReverseWords_0151
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
