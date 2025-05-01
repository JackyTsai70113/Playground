namespace playground.LeetCode._0000_0999;

public class _0543_DiameterOfBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/diameter-of-binary-tree
    /// </summary>
    public static int DiameterOfBinaryTree(TreeNode root)
    {
        return Dfs(root).diameter;
    }

    private static (int diameter, int depth) Dfs(TreeNode root)
    {
        if (root == null) return (0, 0);
        var left = Dfs(root.left);
        var right = Dfs(root.right);
        int diameter = Math.Max(left.depth + right.depth, Math.Max(left.diameter, right.diameter));
        int dep = 1 + Math.Max(left.depth, right.depth);
        return (diameter, dep);
    }
}
