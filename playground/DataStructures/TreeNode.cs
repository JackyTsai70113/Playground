namespace playground.DataStructures;

/// <summary>
/// binary tree node
/// </summary>
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override string ToString()
    {
        var strs = new List<string>();
        var q = new Queue<TreeNode>();
        q.Enqueue(this);
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            if (node == null)
            {
                strs.Add("null");
                continue;
            }
            strs.Add(node.val.ToString());
            q.Enqueue(node.left);
            q.Enqueue(node.right);
        }
        while (strs[^1] == "null")
            strs.RemoveAt(strs.Count - 1);
        var res = '[' + string.Join(',', strs) + ']';
        return res;
    }
}
