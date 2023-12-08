using System.Text;

namespace playground;

public class Tree2str_0606
{
    /// <summary>
    /// https://leetcode.com/problems/construct-string-from-binary-tree
    /// </summary>
    public static string Tree2str(TreeNode root)
    {
        var sb = new StringBuilder();
        Tree2str(root, sb);
        return sb.ToString(1, sb.Length - 2);
    }

    public static void Tree2str(TreeNode root, StringBuilder sb)
    {
        if (root == null)
            return;
        sb.Append('(');
        sb.Append(root.val.ToString());
        Tree2str(root.left, sb);
        if (root.left == null && root.right != null)
            sb.Append("()");
        Tree2str(root.right, sb);
        sb.Append(')');
    }
}
