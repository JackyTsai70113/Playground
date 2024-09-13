namespace playground;

public class XorQueries1310
{
    int[] _arr;
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        _arr = arr;
    }

    public TreeNode SetTreeNode(int l, int r)
    {
        if (l == r)
        {
            return new TreeNode
            {
                val = _arr[l];
            };
        }
        int m = l + (r - l) / 2;
        var node = new TreeNode
        {
            start = l,
            end = r,
        }
        node.left = SetTreeNode(l, m);
        node.right = SetTreeNode(m + 1, r);
        node.val = node.left.val ^ node.right.val;
        return node;
    }

    public int Query(TreeNode node, int l, int r)
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
            return left ^ right
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
