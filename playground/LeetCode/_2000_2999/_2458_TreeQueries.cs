using playground.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2458_TreeQueries
{
    Dictionary<int, int> valToDepth = new(), valToHeight = new();
    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        Dfs(root, 0);
        var depthToHeights = new Dictionary<int, (int first, int second)>();
        foreach (var kvp in valToDepth)
        {
            int val = kvp.Key, depth = kvp.Value;
            if (!depthToHeights.ContainsKey(depth))
                depthToHeights[depth] = (-1, -1);
            if (valToHeight[val] > depthToHeights[depth].first)
                depthToHeights[depth] = (valToHeight[val], depthToHeights[depth].first);
            else if (valToHeight[val] > depthToHeights[depth].second)
                depthToHeights[depth] = (depthToHeights[depth].first, valToHeight[val]);
        }
        var res = new List<int>();
        foreach (var queryVal in queries)
        {
            var depth = valToDepth[queryVal];
            var height = valToHeight[queryVal];
            if (depthToHeights[depth].second == -1)
                res.Add(depth - 1);
            else if (height == depthToHeights[depth].first)
                res.Add(depth + depthToHeights[depth].second);
            else
                res.Add(depth + depthToHeights[depth].first);
        }
        return res.ToArray();
    }

    public int Dfs(TreeNode root, int depth)
    {
        if (root == null) return -1;
        valToDepth[root.val] = depth;
        var left = Dfs(root.left, 1 + depth);
        var right = Dfs(root.right, 1 + depth);
        return valToHeight[root.val] = 1 + Math.Max(left, right);
    }

    int maxH = 0;
    readonly int[] preHeight = new int[100001];
    readonly int[] postHeight = new int[100001];
    /// <summary>
    /// https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries
    /// </summary>
    public int[] TreeQueries2(TreeNode root, int[] queries)
    {
        PreOrder(root, 0);
        maxH = 0;
        PostOrder(root, 0);

        int[] maxHeight = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            maxHeight[i] = Math.Max(preHeight[queries[i]], postHeight[queries[i]]);
        }
        return maxHeight;
    }
    private void PreOrder(TreeNode root, int height)
    {
        if (root == null) return;
        preHeight[root.val] = maxH;
        maxH = Math.Max(height, maxH);
        PreOrder(root.left, height + 1);
        PreOrder(root.right, height + 1);
    }

    private void PostOrder(TreeNode root, int height)
    {
        if (root == null) return;
        postHeight[root.val] = maxH;
        maxH = Math.Max(height, maxH);
        PostOrder(root.right, height + 1);
        PostOrder(root.left, height + 1);
    }
}
