namespace playground.LeetCode._0000_0999;

public class _0094_InorderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-inorder-traversal
    /// </summary>
    public static IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new();
        var s = new Stack<TreeNode>();
        var cur = root;
        while (cur != null || s.Count > 0)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }
            cur = s.Pop();
            res.Add(cur.val);
            cur = cur.right;
        }
        return res;
    }
}
