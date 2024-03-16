namespace playground.UnitTest.Utils;

public static class NodeParser
{
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
        int i = 1;
        while (i < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[i] != null)
            {
                node.left = new(arr[i].Value);
                q.Enqueue(node.left);
            }
            i++;
            if (i < arr.Length && arr[i] != null)
            {
                node.right = new(arr[i].Value);
                q.Enqueue(node.right);
            }
            i++;
        }
        return res;
    }

    public static QuadTreeNode ToQuadTreeNode(this string str)
    {
        var arr = str.ToArr<int[]>();
        if (arr.Length == 0) return null;
        var res = new QuadTreeNode(arr[0][1] == 1, arr[0][0] == 1);
        var q = new Queue<QuadTreeNode>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != null)
            {
                node.topLeft = new(arr[j][1] == 1, arr[j][0] == 1);
                q.Enqueue(node.topLeft);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.topRight = new(arr[j][1] == 1, arr[j][0] == 1);
                q.Enqueue(node.topRight);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.bottomLeft = new(arr[j][1] == 1, arr[j][0] == 1);
                q.Enqueue(node.bottomLeft);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.bottomRight = new(arr[j][1] == 1, arr[j][0] == 1);
                q.Enqueue(node.bottomRight);
            }
            j++;
        }
        return res;
    }
}
