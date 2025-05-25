using System;
using System.Text;

namespace playground.LeetCode._3000_3999;

public class _3561_ResultingString
{
    public static string ResultingString(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            sb.Append(s[i]);
            while (sb.Length >= 2)
            {
                int a = sb[^2];
                int b = sb[^1];

                if (Math.Abs(a - b) == 1 || Math.Abs(a - b) == 25)
                {
                    sb.Remove(sb.Length - 2, 2);
                }
                else
                {
                    break;
                }
            }
        }
        return sb.ToString();
    }
}
