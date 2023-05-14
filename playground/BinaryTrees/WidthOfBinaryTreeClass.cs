namespace playground.BinaryTrees;

public class WidthOfBinaryTreeClass
{
    /// <remarks>https://leetcode.com/problems/maximum-width-of-binary-tree</remarks>
    public static int WidthOfBinaryTree(TreeNode root)
    {
        var res = 0;
        List<(TreeNode node, int idx)> l = new()
        {
            (root, 0)
        };
        while (l.Count > 0)
        {
            List<(TreeNode node, int idx)> l2 = new();
            int len = l.Count;
            res = Math.Max(res, l[^1].idx - l[0].idx + 1);
            for (int i = 0; i < len; ++i)
            {
                if (l[i]!.node.left != null) l2.Add((l[i]!.node.left, l[i].idx * 2 + 1));
                if (l[i]!.node.right != null) l2.Add((l[i]!.node.right, l[i].idx * 2 + 2));
            }
            l = l2;
        }
        return res;
    }

    public static int WidthOfBinaryTree2(TreeNode root)
    {
        int maxWidth = 0;
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));

        while (queue.Count > 0)
        {
            int size = queue.Count;
            int left = queue.Peek().Item2;
            int right = left;

            for (int i = 0; i < size; i++)
            {
                (TreeNode node, int index) = queue.Dequeue();
                right = index;

                if (node.left is not null)
                    queue.Enqueue((node.left, 2 * index));

                if (node.right is not null)
                    queue.Enqueue((node.right, 2 * index + 1));
            }
            maxWidth = Math.Max(maxWidth, right - left + 1);
        }
        return maxWidth;
    }
}
