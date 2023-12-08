namespace playground;

public class SumNumbers_0129
{
    /// <summary>
    /// https://leetcode.com/problems/sum-root-to-leaf-numbers
    /// </summary>
    public static int SumNumbers(TreeNode root)
    {
        var res = 0;
        var q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, root.val));
        while (q.Count > 0)
        {
            var (node, num) = q.Dequeue();
            if (node.left == null && node.right == null)
            {
                res += num;
                continue;
            }
            if (node.left != null)
                q.Enqueue((node.left, num * 10 + node.left.val));
            if (node.right != null)
                q.Enqueue((node.right, num * 10 + node.right.val));
        }
        return res;
    }
}
