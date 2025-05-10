using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0965_IsUnivalTree
{
    /// <summary>
    /// https://leetcode.com/problems/univalued-binary-tree
    /// </summary>
    public static bool IsUnivalTree(TreeNode root)
    {
        if (root.left != null)
        {
            if (root.val != root.left.val || !IsUnivalTree(root.left))
                return false;
        }
        if (root.right != null)
        {
            if (root.val != root.right.val || !IsUnivalTree(root.right))
                return false;
        }
        return true;
    }
}
