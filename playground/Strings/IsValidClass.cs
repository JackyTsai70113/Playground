namespace playground.Strings;

public class IsValidClass
{
    /// <remarks>https://leetcode.com/problems/valid-parentheses</remarks>
    public static bool IsValid(string s)
    {
        Stack<int> stack = new();
        for (int i = 0; i < s.Length; ++i)
        {
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(i);
                    break;
                case ')':
                    if (stack.Count == 0)
                        return false;
                    if (s[stack.Pop()] != '(')
                        return false;
                    break;
                case ']':
                    if (stack.Count == 0)
                        return false;
                    if (s[stack.Pop()] != '[')
                        return false;
                    break;
                case '}':
                    if (stack.Count == 0)
                        return false;
                    if (s[stack.Pop()] != '{')
                        return false;
                    break;
            }
        }
        return stack.Count == 0;
    }
}
