namespace playground;

public class Connect_0117
{
    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii
    /// </summary>
    public static Node Connect(Node root)
    {
        var q = new Queue<Node>();
        if (root != null) q.Enqueue(root);
        while (q.Count > 0)
        {
            var l = new List<Node>();
            for (int i = q.Count; i > 0; --i)
            {
                var node = q.Dequeue();
                l.Add(node);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            for (int i = 0; i < l.Count - 1; ++i)
            {
                l[i].next = l[i + 1];
            }
            l[^1].next = null;
        }
        return root;
    }
}
