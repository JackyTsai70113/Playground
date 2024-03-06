using System.Text;

namespace playground;

public class ReverseParentheses1190
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-substrings-between-each-pair-of-parentheses/
    /// </summary>
    public static string ReverseParentheses(string s)
    {
        var stack = new Stack<int>();
        var chs = s.ToCharArray();

        for (var i = 0; i < chs.Length; i++)
        {
            if (chs[i] == '(')
            {
                stack.Push(i);
            }
            else if (chs[i] == ')')
            {
                var left = stack.Pop() + 1;
                Array.Reverse(chs, left, i - left);
            }
        }
        return new string(chs.Where(c => c != '(' && c != ')').ToArray());
    }
}
