namespace playground.UnitTest.Utils;

public static class NodeParser
{
    public static Node ToNode(this string str)
    {
        var arr = str.ToArr<int?>();
        if (arr.Length == 0) return null;
        var res = new Node(arr[0].Value);
        var q = new Queue<Node>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != null)
            {
                node.left = new(arr[j].Value);
                q.Enqueue(node.left);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.right = new(arr[j].Value);
                q.Enqueue(node.right);
            }
            j++;
        }
        return res;
    }

    public static ListNode ToListNode(this string str)
    {
        ListNode res = new(), p = res;
        var nums = str.ToArr();
        foreach (var num in nums)
        {
            p.next = new ListNode(num);
            p = p.next;
        }
        return res.next;
    }

    public static TreeNode ToTreeNode(this string str)
    {
        var arr = str.ToArr<int?>();
        if (arr.Length == 0) return null;
        var res = new TreeNode(arr[0].Value);
        var q = new Queue<TreeNode>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != null)
            {
                node.left = new(arr[j].Value);
                q.Enqueue(node.left);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.right = new(arr[j].Value);
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
