using System.Text;

namespace playground;

public class GetDirections2096
{
    public static string GetDirections(TreeNode root, int start, int dest)
    {
        List<char> toStart = new(), toDest = new();
        Dfs(root, start, toStart);
        Dfs(root, dest, toDest);
        int i = 0;
        while (i < toStart.Count && i < toDest.Count &&
            toStart[^(i + 1)] == toDest[^(i + 1)])
        {
            i++;
        }
        return new string('U', toStart.Count - i) +
            new string(toDest.Take(toDest.Count - i).Reverse().ToArray());
    }

    public static bool Dfs(TreeNode root, int val, List<char> cur)
    {
        if (root == null)
            return false;
        if (root.val == val)
            return true;
        if (Dfs(root.left, val, cur))
        {
            cur.Add('L');
            return true;
        }
        if (Dfs(root.right, val, cur))
        {
            cur.Add('R');
            return true;
        }
        return false;
    }
}
