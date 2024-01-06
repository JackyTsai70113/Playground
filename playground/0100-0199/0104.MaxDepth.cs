namespace playground;

public class MaxDepth104
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree
    /// </summary>
    public static int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        return 1+Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
