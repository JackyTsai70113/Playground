namespace playground;

/// <summary>
/// https://leetcode.com/problems/min-stack
/// </summary>
public class MinStack0155
{
    Stack<int> stack = new();
    Stack<int> minStack = new();
    public MinStack0155()
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
