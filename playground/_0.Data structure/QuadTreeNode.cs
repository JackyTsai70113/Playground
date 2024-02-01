using System.Text;

namespace playground;

/// <summary>
/// QuadTree node
/// </summary>
public class QuadTreeNode
{
    public bool val;
    public bool isLeaf;
    public QuadTreeNode topLeft;
    public QuadTreeNode topRight;
    public QuadTreeNode bottomLeft;
    public QuadTreeNode bottomRight;
    public QuadTreeNode(
        bool val,
        bool isLeaf,
        QuadTreeNode topLeft = null,
        QuadTreeNode topRight = null,
        QuadTreeNode bottomLeft = null,
        QuadTreeNode bottomRight = null)
    {
        this.val = val;
        this.isLeaf = isLeaf;
        this.topLeft = topLeft;
        this.topRight = topRight;
        this.bottomLeft = bottomLeft;
        this.bottomRight = bottomRight;
    }

    public override string ToString()
    {
        var strs = new List<string>();
        var q = new Queue<QuadTreeNode>();
        q.Enqueue(this);
        var sb = new StringBuilder();
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            if (node == null)
            {
                strs.Add("null");
                continue;
            }
            q.Enqueue(node.topLeft);
            q.Enqueue(node.topRight);
            q.Enqueue(node.bottomLeft);
            q.Enqueue(node.bottomRight);

            sb.Clear();
            sb.Append('[');
            sb.Append(node.isLeaf ? '1' : '0');
            sb.Append(',');
            sb.Append(node.val ? '1' : '0');
            sb.Append(']');
            strs.Add(sb.ToString());
        }
        while (strs[^1] == "null")
            strs.RemoveAt(strs.Count - 1);
        var res = '[' + string.Join(',', strs) + ']';
        return res;
    }
}
