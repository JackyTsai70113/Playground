using System.Text;

namespace playground;

public class Codec0449
{
    // Encodes a tree to a single string.
    public static string Serialize(TreeNode root)
    {
        if (root == null) return string.Empty;
        StringBuilder sb = new();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var node = q.Dequeue();
            if (node == null)
            {
                sb.Append(",");
                continue;
            }
            sb.Append(node.val + ",");
            q.Enqueue(node.left);
            q.Enqueue(node.right);
        }
        return sb.ToString().TrimEnd(',');
    }

    // Decodes your encoded data to tree.
    public static TreeNode Deserialize(string data)
    {
        if (data == string.Empty) return null;
        var arr = data.Split(',');
        var res = new TreeNode(int.Parse(arr[0]));
        var q = new Queue<TreeNode>();
        q.Enqueue(res);
        int i = 1;
        while (i < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[i] != string.Empty)
            {
                node.left = new(int.Parse(arr[i]));
                q.Enqueue(node.left);
            }
            i++;
            if (i < arr.Length && arr[i] != string.Empty)
            {
                node.right = new(int.Parse(arr[i]));
                q.Enqueue(node.right);
            }
            i++;
        }
        return res;
    }
}
