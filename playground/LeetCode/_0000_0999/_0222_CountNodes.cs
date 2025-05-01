namespace playground.LeetCode._0000_0999;

public class _0222_CountNodes
{
    /// <summary>
    /// https://leetcode.com/problems/count-complete-tree-nodes
    /// </summary>
    public static int CountNodes(TreeNode root)
    {
        var res = 0;
        var q = new Queue<TreeNode>();
        if (root != null) q.Enqueue(root);
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            res++;
            if (node.left != null)
                q.Enqueue(node.left);
            if (node.right != null)
                q.Enqueue(node.right);
        }
        return res;
    }
}
