using System.Transactions;

namespace playground;

public class GetMinimumDifference_0530
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-absolute-difference-in-bst
    /// </summary>
    public static int GetMinimumDifference(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        int res = int.MaxValue;
        int? last = null;
        var cur = root;
        while (cur != null)
        {
            stack.Push(cur);
            cur = cur.left;
        }
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (last.HasValue)
                res = Math.Min(res, node.val - last.Value);
            last = node.val;
            var right = node.right;
            while (right != null)
            {
                stack.Push(right);
                right = right.left;
            }
        }
        return res;
    }

    public static int GetMinimumDifference2(TreeNode root)
    {
        int res = int.MaxValue, last = int.MaxValue;
        void Traverse(TreeNode node)
        {
            if (node == null) return;
            Traverse(node.left);
            if (last != int.MaxValue)
                res = Math.Min(res, node.val - last);
            last = node.val;
            Traverse(node.right);
        }
        Traverse(root);
        return res;
    }
}
