using System.Text;

namespace playground;

public class GetDirections2096
{
    public static string GetDirections(TreeNode root, int start, int dest)
    {
        var (toStart, toDest) = Dfs(root, start, dest);
        int i = 0;
        for (; i < Math.Min(toStart.Length, toDest.Length); i++)
        {
            if (toStart[i] != toDest[i])
                break;
        }
        return new string('U', toStart.Length - i) + toDest.ToString(i, toDest.Length);
    }

    public static (StringBuilder toStart, StringBuilder toDest) Dfs(TreeNode root, int start, int dest)
    {
        StringBuilder toStart = null, toDest = null;
        if (root.val == start)
        {
            toStart = new();
        }
        if (root.val == dest)
        {
            toDest = new();
        }
        if (root.left != null)
        {
            var left = Dfs(root.left, start, dest);
            if (left.toStart != null)
            {
                toStart = new StringBuilder("L");
                toStart.Append(left.toStart);
            }
            if (left.toDest != null)
            {
                toDest = new StringBuilder("L");
                toDest.Append(left.toDest);
            }
        }
        if (root.right != null)
        {
            var right = Dfs(root.right, start, dest);
            if (right.toStart != null)
            {
                toStart = new StringBuilder("R");
                toStart.Append(right.toStart);
            }
            if (right.toDest != null)
            {
                toDest = new StringBuilder("R");
                toDest.Append(right.toDest);
            }
        }
        return (toStart, toDest);
    }
}
