using playground.DataStructures;

namespace playground.LeetCode._1000_1999;

public class _1028_RecoverFromPreorder
{
    /// <summary>
    /// https://leetcode.com/problems/recover-a-tree-from-preorder-traversal
    /// </summary>
    public static TreeNode RecoverFromPreorder(string s)
    {
        var stack = new Stack<TreeNode>();
        int n = s.Length, i = 0, depth, val;
        while (i < n)
        {
            depth = 0; val = 0;
            for (; s[i] == '-'; i++)
                depth++;
            for (; i < n && s[i] != '-'; i++)
                val = val * 10 + s[i] - '0';
            while (stack.Count > depth)
                stack.Pop();
            var node = new TreeNode(val);
            if (stack.Count > 0)
            {
                if (stack.Peek().left == null)
                    stack.Peek().left = node;
                else
                    stack.Peek().right = node;
            }
            stack.Push(node);
        }
        while (stack.Count > 1) stack.Pop();
        return stack.Peek();
    }
}
