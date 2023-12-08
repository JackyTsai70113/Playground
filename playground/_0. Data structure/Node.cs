namespace playground;

public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(int _val)
    {
        val = _val;
    }

    public override string ToString()
    {
        var strs = new List<string>();
        var q = new Queue<Node>();
        q.Enqueue(this);
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                var node = q.Dequeue();
                strs.Add(node.val.ToString());
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
            strs.Add("#");
        }
        var res = '[' + string.Join(',', strs) + ']';
        return res;
    }
}