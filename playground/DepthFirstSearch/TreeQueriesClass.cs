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

    public static int[] TreeQueries2(TreeNode root, int[] qs)
    {
        Dictionary<int, int> heights = new(), depths = new();
        int SetHeightAndDepth(TreeNode root, int depth)
        {
            if (root == null)
                return -1;
            int left = SetHeightAndDepth(root.left, depth + 1);
            int right = SetHeightAndDepth(root.right, depth + 1);
            depths[root.val] = depth;
            heights[root.val] = 1 + Math.Max(left, right);
            return heights[root.val];
        }
        SetHeightAndDepth(root, 0);

        Dictionary<int, List<int>> depthHeights = new();
        int depth = 0;
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            depthHeights[depth] = new List<int>();
            PriorityQueue<int, int> pq = new();
            for (int i = q.Count; i > 0; --i)
            {
                var node = q.Dequeue();
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
                pq.Enqueue(heights[node.val], -heights[node.val]);
            }
            depthHeights[depth].Add(pq.Dequeue());
            if (pq.Count > 0) depthHeights[depth].Add(pq.Dequeue());
            depth++;
        }

        var res = new int[qs.Length];
        for (int i = 0; i < qs.Length; ++i)
        {
            var d = depths[qs[i]];
            if (depthHeights[d].Count == 1)
            {
                res[i] = d - 1;
            }
            else if (heights[qs[i]] < depthHeights[d][0])
            {
                res[i] = d + depthHeights[d][0];
            }
            else
            {
                res[i] = d + depthHeights[d][1];
            }
        }
        return res;
    }
}