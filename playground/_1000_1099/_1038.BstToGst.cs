namespace playground;

public class BstToGst1038
{
    int pre = 0;

    /// <summary>
    /// https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree
    /// </summary>
    public TreeNode BstToGst(TreeNode root)
    {
        if (root.right != null)
            BstToGst(root.right);
        pre = root.val = pre + root.val;
        if (root.left != null)
            BstToGst(root.left);
        return root;
    }
}
