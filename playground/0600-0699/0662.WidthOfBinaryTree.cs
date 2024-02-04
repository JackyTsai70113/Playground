namespace playground;

public class WidthOfBinaryTree0662
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-of-binary-tree
    /// </summary>
    public static int WidthOfBinaryTree(TreeNode root)
    {
        int res = 0, leftIndex, rightIndex = 0;
        var q = new Queue<(TreeNode node, int index)>();
        q.Enqueue((root, 0));
        while (q.Count > 0)
        {
            leftIndex = q.Peek().index;
            for (int i = q.Count; i > 0; i--)
            {
                var (node, index) = q.Dequeue();
                if (i == 1)
                    rightIndex = index;
                if (node.left != null)
                    q.Enqueue((node.left, 2 * index + 1));
                if (node.right != null)
                    q.Enqueue((node.right, 2 * index + 2));
            }
            res = Math.Max(res, rightIndex - leftIndex + 1);
        }
        return res;
    }
}
