using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0104_MaxDepth
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree
    /// </summary>
    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
