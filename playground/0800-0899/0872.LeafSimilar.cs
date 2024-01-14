namespace playground;

public class LeafSimilar0872
{
    /// <summary>
    /// https://leetcode.com/problems/leaf-similar-trees
    /// </summary>
    public static bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        Stack<TreeNode> s1 = new(), s2 = new();
        s1.Push(root1); s2.Push(root2);
        while (s1.Any() && s2.Any())
            if (Dfs(s1) != Dfs(s2)) return false;
        return s1.Count == 0 && s2.Count == 0;
    }

    static int Dfs(Stack<TreeNode> s)
    {
        while (true)
        {
            TreeNode node = s.Pop();
            if (node.left == null && node.right == null)
                return node.val;
            if (node.right != null) s.Push(node.right);
            if (node.left != null) s.Push(node.left);
        }
    }
}
