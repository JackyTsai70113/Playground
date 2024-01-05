namespace playground;

public class InvertTree0226
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
