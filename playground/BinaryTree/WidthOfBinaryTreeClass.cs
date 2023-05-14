namespace playground.BinaryTree;

public class WidthOfBinaryTreeClass
{
    /// <remarks>https://leetcode.com/problems/maximum-width-of-binary-tree</remarks>
    public static int WidthOfBinaryTree(TreeNode root)
    {
        var res = 0;
        List<(TreeNode node, int idx)> l = new()
        {
            (root, 0)
        };
        while (l.Count > 0)
        {
            List<(TreeNode node, int idx)> l2 = new();
            int len = l.Count;
            res = Math.Max(res, l[^1].idx - l[0].idx + 1);
            for (int i = 0; i < len; ++i)
            {
                if (l[i]!.node.left != null) l2.Add((l[i]!.node.left, l[i].idx * 2 + 1));
                if (l[i]!.node.right != null) l2.Add((l[i]!.node.right, l[i].idx * 2 + 2));
            }
            l = l2;
        }
        return res;
    }
}
