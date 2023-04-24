namespace playground.UnitTest.Utils;

public static class TreeNodeParser
{
    public static playground.TreeNode.TreeNode? ToTreeNode(this string str)
    {
        var arr = str.ToArr<string>();
        if (arr.Length == 0 || arr[0] == "null") return null;
        var res = new playground.TreeNode.TreeNode(int.Parse(arr[0]));
        var q = new Queue<playground.TreeNode.TreeNode>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != "null")
            {
                node.left = new playground.TreeNode.TreeNode(int.Parse(arr[j]));
                q.Enqueue(node.left);
            }
            j++;
            if (j < arr.Length && arr[j] != "null")
            {
                node.right = new playground.TreeNode.TreeNode(int.Parse(arr[j]));
                q.Enqueue(node.right);
            }
            j++;
        }
        return res;
    }
}
