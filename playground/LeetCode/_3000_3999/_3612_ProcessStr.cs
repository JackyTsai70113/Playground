using System.Text;

namespace playground.LeetCode._3000_3999;

public class _3612_ProcessStr
{
    public static string ProcessStr(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (char.IsLetter(c))
            {
                sb.Append(c);
            }
            else if (c == '*')
            {
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            else if (c == '#')
            {
                var temp = sb.ToString();
                sb.Append(temp);
            }
            else if (c == '%')
            {
                var temp = sb.ToString().ToCharArray();
                Array.Reverse(temp);
                sb.Clear();
                sb.Append(temp);
            }
        }
        return sb.ToString();
    }
}
