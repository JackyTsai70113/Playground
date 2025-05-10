using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0098_IsValidBST
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree
    /// </summary>
    public static bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }

    public static bool IsValidBST(TreeNode node, int? left, int? right)
    {
        if (node == null) return true;
        if (node.left != null)
        {
            if (node.left.val >= node.val)
                return false;
            if (left.HasValue && left >= node.left.val)
                return false;
        }
        if (node.right != null)
        {
            if (node.val >= node.right.val)
                return false;
            if (right.HasValue && node.right.val >= right)
                return false;
        }
        return IsValidBST(node.left, left, node.val) &&
            IsValidBST(node.right, node.val, right);
    }
}
