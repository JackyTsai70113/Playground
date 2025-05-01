namespace playground.LeetCode._0000_0999;

public class _0224_Calculate
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
            else if ('0' <= c && c <= '9')
            {
                val = val * 10 + c - '0';
            }
        }
        return res + sign * val;
    }

    public static int Calculate2(string s)
    {
        Stack<int> vals = new();
        Stack<int> signs = new();
        int sign = 1; // 後面算式的正負號
        int val = 0; // 當前數值
        int res = 0; // 算式結果
        foreach (var c in s)
        {
            if (c == '(')
            {
                vals.Push(res);
                signs.Push(sign);
                val = 0;
                res = 0;
                sign = 1;
            }
            else if ('0' <= c && c <= '9')
            {
                val = 10 * val + c - '0';
            }
            else if (c == '+')
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
            else if (c == ')')
            {
                res += sign * val;
                sign = 1;
                val = 0;
                res *= signs.Pop();
                res += vals.Pop();
            }
        }
        return res + sign * val;
    }
}
