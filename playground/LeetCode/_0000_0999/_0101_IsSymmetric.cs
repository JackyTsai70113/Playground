using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0101_IsSymmetric
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree
    /// </summary>
    public static bool IsSymmetric(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root.left);
        q.Enqueue(root.right);
        while (q.Count > 0)
        {
            var right = q.Dequeue();
            var left = q.Dequeue();
            if (left == null && right == null)
                continue;
            if (left == null || right == null)
                return false;
            if (left.val != right.val)
                return false;
            q.Enqueue(left.left);
            q.Enqueue(right.right);
            q.Enqueue(left.right);
            q.Enqueue(right.left);
        }
        return true;
    }
}
