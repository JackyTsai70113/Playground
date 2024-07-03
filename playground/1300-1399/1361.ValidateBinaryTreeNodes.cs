namespace playground;

public class ValidateBinaryTreeNodes1361
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-tree-nodes
    /// </summary>
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        _groups = Enumerable.Range(0, n).ToArray();
        int groupCount = n;
        for (int i = 0; i < n; i++)
        {
            if (leftChild[i] != -1)
            {
                int leftChildGroup = Find(leftChild[i]);
                if (leftChildGroup != leftChild[i])
                    return false;
                if (!Union(i, leftChild[i]))
                    return false;
                groupCount--;
            }
            if (rightChild[i] != -1)
            {
                int rightChildGroup = Find(rightChild[i]);
                if (rightChildGroup != rightChild[i])
                    return false;
                if (!Union(i, rightChild[i]))
                    return false;
                groupCount--;
            }
        }
        return groupCount == 1;
    }

    public int[] _groups;
    int Find(int node)
    {
        if (node != _groups[node])
            _groups[node] = Find(_groups[node]);
        return _groups[node];
    }
    bool Union(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (group1 == group2)
            return false;
        _groups[node2] = group1;
        return true;
    }
}
