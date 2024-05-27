namespace playground;

public class ValidateBinaryTreeNodes1361
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-tree-nodes
    /// </summary>
    public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        var groups = Enumerable.Range(0, n).ToArray();
        int Find(int node)
        {
            if (node != groups[node])
                groups[node] = Find(groups[node]);
            return groups[node];
        }
        bool Union(int node1, int node2)
        {
            int group1 = Find(node1);
            int group2 = Find(node2);
            if (group1 == group2) return false;
            if (node2 != group2) return false; // check if node2 already has parent.
            groups[group2] = group1; // parent of node2 = node1
            return true;
        }
        int groupCount = n;
        for (int i = 0; i < n; i++)
        {
            if (leftChild[i] != -1)
            {
                if (!Union(i, leftChild[i]))
                    return false;
                groupCount--;
            }
            if (rightChild[i] != -1)
            {
                if (!Union(i, rightChild[i]))
                    return false;
                groupCount--;
            }
        }
        return groupCount == 1;
    }
}
