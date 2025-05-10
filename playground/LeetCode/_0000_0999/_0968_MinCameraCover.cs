using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0968_MinCameraCover
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-cameras
    /// </summary>
    public static int MinCameraCover(TreeNode root)
    {
        int res = 0;
        int dfs(TreeNode node)
        {
            if (node == null) return 2;
            int l = dfs(node.left), r = dfs(node.right);
            if (l == 0 || r == 0)
            {
                res++;
                return 1;
            }
            return l == 1 || r == 1 ? 2 : 0;
        }
        return dfs(root) == 0 ? res + 1 : res;
    }
}
