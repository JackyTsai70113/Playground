using playground.BinaryTrees;

namespace playground.UnitTest.Utils;

public static class TreeNodeParser
{
    public static TreeNode ToTreeNode(this string str)
    {
        var arr = str.ToArr<string>();
        if (arr.Length == 0 || arr[0] == "null") return null;
        var res = new TreeNode(int.Parse(arr[0]));
        var q = new Queue<TreeNode>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != "null")
            {
                node.left = new TreeNode(int.Parse(arr[j]));
                q.Enqueue(node.left);
            }
            j++;
            if (j < arr.Length && arr[j] != "null")
            {
                node.right = new TreeNode(int.Parse(arr[j]));
                q.Enqueue(node.right);
            }
            j++;
        }
        return res;
    }

    public static bool IsSameTree(this TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
