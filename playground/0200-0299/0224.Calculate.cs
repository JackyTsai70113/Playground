namespace playground;

public class Calculate_0224
{
    /// <summary>
    /// https://leetcode.com/problems/basic-calculator
    /// s consists of digits, '+', '-', '(', ')', and ' '.
    /// </summary>
    public static int Calculate(string s)
    {
        var stack = new Stack<int>();
        int res = 0, sign = 1, val = 0;

        foreach (var c in s)
        {
            if (c == '+')
            {
                res += sign * val;
                sign = 1;
                val = 0;
            }
            else if (c == '-')
            {
                res += sign * val;
                sign = -1;
                val = 0;
            }
            else if (c == '(')
            {
                stack.Push(res);
                stack.Push(sign);
                res = 0;
                sign = 1;
            }
            else if (c == ')')
            {
                res += sign * val;
                res *= stack.Pop();
                res += stack.Pop();
                val = 0;
            }
            else if (c == ' ')
            {
                continue;
            }
            else
            {
                val = val * 10 + c - '0';
            }
        }
        return res + sign * val;
    }
}
