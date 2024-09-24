namespace playground;

public class XorQueries1310
{
    int[] _arr;
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        _arr = arr;
        var root = SetTreeNode(0, arr.Length - 1);
        var res = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            res[i] = Query(root, queries[i][0], queries[i][1]);
        }
        return res;
    }

    public TreeNode SetTreeNode(int l, int r)
    {
        var res = new TreeNode
        {
            start = l,
            end = r
        };
        if (l == r)
        {
            res.val = _arr[l];
            return res;
        }
        int m = l + (r - l) / 2;
        res.left = SetTreeNode(l, m);
        res.right = SetTreeNode(m + 1, r);
        res.val = res.left.val ^ res.right.val;
        return res;
    }

    public static int Query(TreeNode node, int l, int r)
    {
        if (l == node.start && r == node.end)
            return node.val;
        int m = node.start + (node.end - node.start) / 2;
        if (m >= r)
            return Query(node.left, l, r);
        else if (m + 1 <= l)
            return Query(node.right, l, r);
        else
        {
            int left = Query(node.left, l, m);
            int right = Query(node.right, m + 1, r);
            return left ^ right;
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;
        public int start;
        public int end;
    }
}
