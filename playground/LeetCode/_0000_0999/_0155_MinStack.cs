namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/min-stack
/// </summary>
public class _0155_MinStack
{
    readonly Stack<int> stack = new();
    readonly Stack<int> minStack = new();
    public _0155_MinStack()
    {

    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
            minStack.Push(val);
    }

    public void Pop()
    {
        var top = stack.Pop();
        if (top == minStack.Peek())
            minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
