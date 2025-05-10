using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0226_InvertTree
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree
    /// </summary>
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
