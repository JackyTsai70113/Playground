namespace playground;

public class IsUnivalTree0965
{
    /// <summary>
    /// https://leetcode.com/problems/univalued-binary-tree
    /// </summary>
    public static bool IsUnivalTree(TreeNode root) {
        if(root.left != null){
            if(root.val != root.left.val || !IsUnivalTree(root.left))
                return false;
        }
        if(root.right != null){
            if(root.val != root.right.val || !IsUnivalTree(root.right))
                return false;
        }
        return true;
    }
}
