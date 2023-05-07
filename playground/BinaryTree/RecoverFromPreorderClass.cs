namespace playground.BinaryTree;

public class RecoverFromPreorderClass
{
    public static TreeNode RecoverFromPreorder(string s)
    {
        var stack = new Stack<TreeNode>();
        int i = 0, level, val;
        while (i < s.Length)
        {
            level = 0;
            val = 0;
            for (; i < s.Length && s[i] == '-'; ++i)
                level++;
            for (; i < s.Length && s[i] != '-'; ++i)
                val = val * 10 + s[i] - '0';
            while (stack.Count > level)
                stack.Pop();
            var node = new TreeNode(val);
            if (stack.Peek().left == null)
                stack.Peek().left = node;
            else
                stack.Peek().right = node;
            stack.Push(node);
        }
        while (stack.Count > 1)
            stack.Pop();
        return stack.Pop();
    }
}
