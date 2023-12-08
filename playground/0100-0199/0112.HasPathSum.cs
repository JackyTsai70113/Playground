namespace playground;

public class HasPathSum_0112
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum
    /// </summary>
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;
        var q = new Queue<(TreeNode node, int num)>();
        q.Enqueue((root, targetSum));
        while (q.Count > 0)
        {
            var (node, num) = q.Dequeue();
            if (node.left == null && node.right == null && num == node.val)
                return true;
            if (node.left != null)
                q.Enqueue((node.left, num - node.val));
            if (node.right != null)
                q.Enqueue((node.right, num - node.val));
        }
        return false;
    }
}
