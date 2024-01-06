namespace playground;

public class PathSum0113
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum-ii
    /// </summary>
    public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        var res = new List<IList<int>>();
        Dfs(root, targetSum, new List<int>(), res);
        return res;
    }
    private static void Dfs(TreeNode root, int targetSum, List<int> cur, IList<IList<int>> res)
    {
        if (root == null) return;
        if (root.left == null && root.right == null)
        {
            if (targetSum == root.val)
            {
                var temp = new List<int>(cur);
                temp.Add(root.val);
                res.Add(temp);
            }
            return;
        }
        cur.Add(root.val);
        if (root.left != null) Dfs(root.left, targetSum - root.val, cur, res);
        if (root.right != null) Dfs(root.right, targetSum - root.val, cur, res);
        cur.RemoveAt(cur.Count - 1);
    }
}
