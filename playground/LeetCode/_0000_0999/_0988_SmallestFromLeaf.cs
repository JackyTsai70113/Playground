using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0988_SmallestFromLeaf
{
    /// <summary>
    /// https://leetcode.com/problems/smallest-string-starting-from-leaf
    /// </summary>
    public static string SmallestFromLeaf(TreeNode root)
    {
        return Dfs(root, string.Empty);
    }

    private static string Dfs(TreeNode root, string pre)
    {
        if (root == null) return pre;
        pre = (char)(root.val + 'a') + pre;
        var left = Dfs(root.left, pre);
        var right = Dfs(root.right, pre);
        if (root.left == null)
            return right;
        if (root.right == null)
            return left;
        return left.CompareTo(right) < 0 ? left : right;
    }
}