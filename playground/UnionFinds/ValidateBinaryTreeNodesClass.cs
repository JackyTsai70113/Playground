namespace playground.UnionFinds;

public class ValidateBinaryTreeNodesClass
{
    public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        var uf = new UnionFind2(n);
        var componentsCount = n;
        for (int i = 0; i < n; ++i)
        {
            if (leftChild[i] != -1)
            {
                if (uf.Join(i, leftChild[i]) is false)
                    return false;
                componentsCount--;
            }
            if (rightChild[i] != -1)
            {
                if (uf.Join(i, rightChild[i]) is false)
                    return false;
                componentsCount--;
            }
        }
        return componentsCount == 1;
    }
}

class UnionFind2
{
    private readonly int[] _roots;
    public UnionFind2(int n)
    {
        _roots = Enumerable.Range(0, n).ToArray();
    }

    public int Find(int i)
    {
        if (_roots[i] != i)
        {
            _roots[i] = Find(_roots[i]);
        }
        return _roots[i];
    }

    public bool Join(int u, int v)
    {
        var uGroup = Find(u);
        var vGroup = Find(v);
        if (uGroup == vGroup) return false; // cycle
        if (v != vGroup) return false; // parent is occupied
        _roots[v] = uGroup;
        return true;
    }
}
