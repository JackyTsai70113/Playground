namespace playground.LeetCode._0000_0999;

public class _0404_SumOfLeftLeaves
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-left-leaves
    /// </summary>
    public static int SumOfLeftLeaves(TreeNode root)
    {
        int res = 0;
        if (root.left != null)
            res += Dfs(root.left, true);
        if (root.right != null)
            res += Dfs(root.right, false);
        return res;
    }

    private static int Dfs(TreeNode root, bool isLeft)
    {
        int res = 0;
        if (root.left == null && root.right == null && isLeft)
            res += root.val;
        if (root.left != null)
            res += Dfs(root.left, true);
        if (root.right != null)
            res += Dfs(root.right, false);
        return res;
    }
}
