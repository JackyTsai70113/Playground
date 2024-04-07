using System.Text;

namespace playground;

public class MinRemoveToMakeValid1249
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses
    /// </summary>
    public static string MinRemoveToMakeValid(string s)
    {
        int count = 0;
        StringBuilder sb = new();
        foreach (var c in s)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                if (count == 0)
                    continue;
                count--;
            }
            sb.Append(c);
        }
        for (int i = sb.Length - 1; i >= 0 && count > 0; i--)
        {
            if (sb[i] == '(')
            {
                sb.Remove(i, 1);
                count--;
            }
        }
        return sb.ToString();
    }
}
