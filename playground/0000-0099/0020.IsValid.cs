namespace playground;

public class IsValid_0020
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses
    /// </summary>
    public static bool IsValid(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> d = new Dictionary<char, char> {
            {'(',')'},
            {'[',']'},
            {'{','}'}
        };
        foreach(var c in s){
            if(d.ContainsKey(c))
                stack.Push(d[c]);
            else if(stack.Count > 0 && stack.Peek() == c)
                stack.Pop();
            else 
            return false;
        }
        return stack.Count == 0;
    }
}
