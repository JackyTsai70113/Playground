namespace playground;

public class _1598_MinOperations
{
    /// <summary>
    /// https://leetcode.com/problems/crawler-log-folder
    /// </summary>
    public static int MinOperations(string[] logs)
    {
        var stack = new Stack<string>();
        foreach (var log in logs)
        {
            if (log == "../")
            {
                stack.TryPop(out var _);
            }
            else if (log != "./")
            {
                stack.Push(log);
            }
        }
        return stack.Count;
    }
}
