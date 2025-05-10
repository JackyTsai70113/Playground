using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0979_DistributeCoins
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-coins-in-binary-tree
    /// </summary>
    public static int DistributeCoins(TreeNode root)
    {
        int[] res = new int[1];
        Dfs(root, res);
        return res[0];
    }

    public static int Dfs(TreeNode root, int[] res)
    {
        if (root == null)
            return 0;
        int l = Dfs(root.left, res);
        int r = Dfs(root.right, res);
        res[0] += Math.Abs(l) + Math.Abs(r);
        return root.val - 1 + l + r;
    }
}
