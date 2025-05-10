using playground.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2196_CreateBinaryTree
{
    public static TreeNode CreateBinaryTree(int[][] A)
    {
        var nodes = new Dictionary<int, TreeNode>();
        var parents = new Dictionary<int, int>();
        foreach (var a in A)
        {
            if (!nodes.ContainsKey(a[0]))
            {
                nodes[a[0]] = new TreeNode(a[0]);
            }
            if (!nodes.ContainsKey(a[1]))
            {
                nodes[a[1]] = new TreeNode(a[1]);
            }
            parents[a[1]] = a[0];
            if (a[2] == 1)
                nodes[a[0]].left = nodes[a[1]];
            else
                nodes[a[0]].right = nodes[a[1]];
        }

        return nodes[GetParent(A[0][1], parents)];
    }

    private static int GetParent(int i, Dictionary<int, int> parents)
    {
        while (parents.ContainsKey(i))
        {
            return GetParent(parents[i], parents);
        }
        return i;
    }
}
