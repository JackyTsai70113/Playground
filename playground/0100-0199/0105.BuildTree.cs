namespace playground;

public class BuildTree_0105
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
    /// </summary>
    public static TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return BuildTree(preorder, inorder, 0, 0, inorder.Length - 1);
    }

    public static TreeNode BuildTree(
        int[] preorder, int[] inorder,
        int preStart, int inStart, int inEnd)
    {
        if (preStart >= preorder.Length || inStart > inEnd)
            return null;

        int inIndex = 0;
        for (int i = inStart; i <= inEnd; ++i)
        {
            if (inorder[i] == preorder[preStart])
            {
                inIndex = i;
                break;
            }
        }

        TreeNode root = new TreeNode(preorder[preStart]);
        root.left = BuildTree(preorder, inorder, preStart + 1, inStart, inIndex - 1);
        root.right = BuildTree(preorder, inorder, preStart + 1 + inIndex - inStart, inIndex + 1, inEnd);
        return root;
    }
}
