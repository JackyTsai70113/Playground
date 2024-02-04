namespace playground.BreadthFirstSearch;

public class DistanceKClass
{
    /// <summary>
    /// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree
    /// </summary>
    public static IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        var d = new Dictionary<int, List<int>>();
        void dfs(TreeNode parent, TreeNode child)
        {
            if (child != null && !d.ContainsKey(child.val))
                d[child.val] = new List<int>();
            if (parent != null && child != null)
            {
                d[parent.val].Add(child.val);
                d[child.val].Add(parent.val);
            }
            if (child != null)
            {
                dfs(child, child.left);
                dfs(child, child.right);
            }
        }
        dfs(null, root);

        var res = new List<int> { target.val };
        var seen = new HashSet<int>(res);
        for (int i = 0; i < k; i++)
        {
            var newLevel = new List<int>();
            foreach (var node in res)
            {
                foreach (var next in d[node])
                {
                    if (!seen.Contains(next))
                        newLevel.Add(next);
                }
            }
            seen.UnionWith(new HashSet<int>(newLevel));
            res = newLevel;
        }
        return res;
    }
}
