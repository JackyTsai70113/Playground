using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0450_DeleteNode
{
    /// <summary>
    /// https://leetcode.com/problems/delete-node-in-a-bst
    /// </summary>
    public static TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;
        TreeNode parent = new TreeNode(0, root), delete_node = root;
        while (delete_node != null)
        {
            if (delete_node.val == key)
            {
                break;
            }
            parent = delete_node;
            if (delete_node.val > key)
            {
                delete_node = delete_node.left;
            }
            else
            {
                delete_node = delete_node.right;
            }
        }
        if (delete_node == null) return root;

        if (delete_node.left == null && delete_node.right == null)
        {
            if (delete_node == root)
            {
                return null;
            }
            if (parent.left == delete_node)
            {
                parent.left = null;
            }
            else
            {
                parent.right = null;
            }
        }
        else if (delete_node.left == null || delete_node.right == null)
        {
            var child = delete_node.left != null ? delete_node.left : delete_node.right;
            if (delete_node == root)
            {
                return child;
            }
            if (parent.left == delete_node)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }
        }
        else
        {
            var successor = LeftMost(delete_node.right);
            int successorVal = successor.val;
            DeleteNode(root, successor.val);
            delete_node.val = successorVal;
        }
        return root;
    }

    static TreeNode LeftMost(TreeNode node)
    {
        while (node.left != null)
            node = node.left;
        return node;
    }
}
