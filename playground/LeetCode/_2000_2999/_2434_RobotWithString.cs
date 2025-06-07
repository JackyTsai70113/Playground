using System.Text;

namespace playground.LeetCode._2000_2999;

public class _2434_RobotWithString
{
    public static string RobotWithString(string s)
    {
        var counter = new int[26];
        foreach (var c in s)
            counter[c - 'a']++;
        var sb = new StringBuilder();
        var stack = new Stack<char>();

        char lowest()
        {
            for (int i = 0; i < 26; i++)
            {
                if (counter[i] != 0)
                {
                    return (char)(i + 'a');
                }
            }
            return 'a';
        }
        foreach (var c in s)
        {
            stack.Push(c);
            counter[c - 'a']--;
            while (stack.Count > 0 && stack.Peek() <= lowest())
            {
                sb.Append(stack.Pop());
            }
        }
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }
}
