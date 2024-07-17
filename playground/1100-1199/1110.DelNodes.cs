namespace playground;

public class DelNodes1110
{
    /// <summary>
    /// https://leetcode.com/problems/delete-nodes-and-return-forest
    /// </summary>
    public static IList<TreeNode> DelNodesIteration(TreeNode root, int[] to_delete)
    {
        var res = new List<TreeNode>();
        var del = to_delete.ToHashSet();
        var q = new Queue<(TreeNode node, bool isRoot)>();
        q.Enqueue((root, true));
        while (q.Count > 0)
        {
            var (node, isRoot) = q.Dequeue();
            var deleted = del.Contains(node.val);
            if (isRoot && !deleted) res.Add(node);
            if (node.left != null)
            {
                q.Enqueue((node.left, deleted));
                if (del.Contains(node.left.val))
                    node.left = null;
            }
            if (node.right != null)
            {
                q.Enqueue((node.right, deleted));
                if (del.Contains(node.right.val))
                    node.right = null;
            }
        }
        return res;
    }

    public static IList<TreeNode> DelNodesRecursion(TreeNode root, int[] to_delete)
    {
        var res = new List<TreeNode>();
        Dfs(root, to_delete.ToHashSet(), true, res);
        return res;
    }

    private static TreeNode Dfs(TreeNode root, HashSet<int> deletedVals, bool isRoot, List<TreeNode> res)
    {
        if (root == null) return null;
        bool needDelete = deletedVals.Contains(root.val);
        if (isRoot && !needDelete)
            res.Add(root);
        root.left = Dfs(root.left, deletedVals, needDelete, res);
        root.right = Dfs(root.right, deletedVals, needDelete, res);
        return needDelete ? null : root;
    }
}
