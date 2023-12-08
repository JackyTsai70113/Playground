namespace playground;

public class BuildTree_0106
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal
    /// </summary>
    public static TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        int n = inorder.Length;
        return BuildTree(inorder, 0, n - 1, postorder, 0, n - 1);
    }

    private static TreeNode BuildTree(int[] inorder, int l1, int r1, int[] postorder, int l2, int r2)
    {
        if (l1 == r1 || l2 == r2)
            return new TreeNode(inorder[l1]);
        if (l1 > r1 || l2 > r2)
            return null;
        int n = inorder.Length;
        var res = new TreeNode();
        res.val = postorder[r2];
        var idx = Array.IndexOf(inorder, res.val);
        res.left = BuildTree(inorder, l1, idx - 1, postorder, l2, l2 + idx - 1 - l1);
        res.right = BuildTree(inorder, idx + 1, r1, postorder, l2 + idx - l1, r2 - 1);
        return res;
    }
}
