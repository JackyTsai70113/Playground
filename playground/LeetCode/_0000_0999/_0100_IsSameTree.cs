using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0100_IsSameTree
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree
    /// </summary>
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        return p.val == q.val &&
            IsSameTree(p.left, q.left) &&
            IsSameTree(p.right, q.right);
    }
}
