namespace playground;

public class _1302_DeepestLeavesSum
{
    /// <summary>
    /// https://leetcode.com/problems/deepest-leaves-sum
    /// </summary>
    public static int DeepestLeavesSum(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var res = 0;
        while (q.Count > 0)
        {
            res = 0;
            for (int i = q.Count; i > 0; i--)
            {
                var node = q.Dequeue();
                res += node.val;
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
        }
        return res;
    }
}
