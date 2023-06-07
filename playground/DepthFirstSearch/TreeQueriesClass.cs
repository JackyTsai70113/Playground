using System.Diagnostics.Metrics;
using playground.BinaryTrees;

namespace playground.DepthFirstSearch;

public class TreeQueriesClass
{
    int maxH = 0;
    readonly int[] preHeight = new int[100001];
    readonly int[] postHeight = new int[100001];
    /// <summary>
    /// https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries
    /// </summary>
    public int[] TreeQueries(TreeNode root, int[] queries)
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
