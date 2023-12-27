namespace playground;

public class MaxPathSum_0124
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-maximum-path-sum
    /// </summary>
    public static int MaxPathSum(TreeNode root)
    {
        int maxSum = int.MinValue;
        Traverse(root, ref maxSum);
        return maxSum;
    }

    public static int Traverse(TreeNode node, ref int maxSum)
    {
        if (node == null) return 0;

        var leftPath = Math.Max(0, Traverse(node.left, ref maxSum));
        var rightPath = Math.Max(0, Traverse(node.right, ref maxSum));
        maxSum = Math.Max(maxSum, node.val + leftPath + rightPath);
        return node.val + Math.Max(leftPath, rightPath);
    }
}
