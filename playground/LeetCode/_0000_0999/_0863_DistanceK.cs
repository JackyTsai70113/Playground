namespace playground.LeetCode._0000_0999;

public class _0863_DistanceK
{
    /// <summary>
    /// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree
    /// </summary>
    public static IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        var g = new Dictionary<int, List<int>>();
        void dfs(TreeNode parent, TreeNode child)
        {
            if (parent != null)
            {
                if (!g.ContainsKey(parent.val)) g[parent.val] = new();
                g[parent.val].Add(child.val);
                if (!g.ContainsKey(child.val)) g[child.val] = new();
                g[child.val].Add(parent.val);
            }
            if (child.left != null) dfs(child, child.left);
            if (child.right != null) dfs(child, child.right);
        }
        dfs(null, root);

        var q = new Queue<int>();
        var seen = new HashSet<int>();
        q.Enqueue(target.val);
        seen.Add(target.val);
        while (q.Count > 0)
        {
            if (k == 0) return q.ToList();
            for (int i = q.Count; i > 0; i--)
            {
                var u = q.Dequeue();
                if (!g.ContainsKey(u)) continue;
                foreach (var v in g[u])
                {
                    if (seen.Contains(v)) continue;
                    seen.Add(v);
                    q.Enqueue(v);
                }
            }
            k--;
        }
        return Array.Empty<int>();
    }
}
