namespace playground;

public class CountPairs1530
{
    int res = 0;
    public int CountPairs(TreeNode root, int distance)
    {
        Dfs(root, distance);
        return res;
    }

    private Dictionary<int, int> Dfs(TreeNode root, int distance)
    {
        if (root == null)
        {
            return new Dictionary<int, int>();
        }
        if (root.left == null && root.right == null)
        {
            return new Dictionary<int, int> { [1] = 1 };
        }
        var left = Dfs(root.left, distance);
        var right = Dfs(root.right, distance);
        foreach (var leftKey in left.Keys)
        {
            foreach (var rightKey in right.Keys)
            {
                if (leftKey + rightKey <= distance)
                    res += left[leftKey] * right[rightKey];
            }
        }

        var d = new Dictionary<int, int>();
        foreach (var key in left.Keys)
        {
            if (key < distance)
                d[key + 1] = left[key];
        }
        foreach (var key in right.Keys)
        {
            if (key < distance)
                d[key + 1] = d.GetValueOrDefault(key + 1) + right[key];
        }
        return d;
    }
}
