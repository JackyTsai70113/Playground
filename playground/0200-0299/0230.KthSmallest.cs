namespace playground;

public class KthSmallest_0230
{
    /// <summary>
    /// https://leetcode.com/problems/kth-smallest-element-in-a-bst
    /// </summary>
    public static int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();
        int res = 0, idx = 1; ;
        var cur = root;
        while (cur != null)
        {
            stack.Push(cur);
            cur = cur.left;
        }
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (idx == k)
            {
                res = node.val;
                break;
            }
            idx++;
            var right = node.right;
            while (right != null)
            {
                stack.Push(right);
                right = right.left;
            }
        }
        return res;
    }
}
