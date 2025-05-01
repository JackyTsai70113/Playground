namespace playground.LeetCode._0000_0999;

public class _0020_IsValid
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses
    /// </summary>
    public static bool IsValid(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> d = new()
        {
            {'(',')'},
            {'[',']'},
            {'{','}'}
        };
        foreach (var c in s)
        {
            if (d.ContainsKey(c))
                stack.Push(d[c]);
            else if (stack.Count > 0 && stack.Peek() == c)
                stack.Pop();
            else
                return false;
        }
        return stack.Count == 0;
    }
}
