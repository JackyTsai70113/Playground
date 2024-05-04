namespace playground;

public class ValidateBinaryTreeNodes1361
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-tree-nodes
    /// </summary>
    public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        int groupCount = n;
        DisjointSet2 ds = new(n);
        for (int i = 0; i < n; i++)
        {
            if (leftChild[i] != -1)
            {
                if (!ds.Union(i, leftChild[i]))
                    return false;
                groupCount--;
            }
            if (rightChild[i] != -1)
            {
                if (!ds.Union(i, rightChild[i]))
                    return false;
                groupCount--;
            }
        }
        return groupCount == 1;
    }
}

public class DisjointSet2
{
    private readonly int[] Groups;
    public DisjointSet2(int n)
    {
        Groups = new int[n];
        for (int i = 0; i < n; ++i)
            Groups[i] = i;
    }

    /// <summary>
    /// 取得 node 的 group
    /// </summary>
    public int Find(int node)
    {
        return Groups[node] = Groups[node] == node ? node : Find(Groups[node]);
    }

    /// <summary>
    /// Union node2 to node1
    /// </summary>
    public bool Union(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (group1 == group2) return false;
        if (node2 != group2) return false; // check if node2 already has parent.
        Groups[group2] = group1; // parent of node2 = node1
        return true;
    }
}
