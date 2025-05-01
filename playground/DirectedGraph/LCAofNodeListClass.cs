namespace playground.DirectedGraph;

public class LCAofNodeListClass
{
    public static List<int> LCAofNaryNodes(NaryTreeNode root, List<int> nodes)
    {
        if (root == null || nodes.Count == 0)
            return new List<int>();
        var valueSet = new HashSet<int>(nodes);
        return LCA(root, valueSet);
    }

    private static List<int> LCA(NaryTreeNode root, HashSet<int> valueSet)
    {
        if (valueSet.Contains(root.val))
            return new List<int> { root.val };
        if (root.children.Count == 0)
            return new List<int>();
        var leafs = new List<int>();
        bool allContains = true;
        foreach (var child in root.children)
        {
            var lcas = LCA(child, valueSet);
            if (lcas.Count == 0 || lcas.Count != 1 || lcas[0] != child.val) // 找不到 或者是 找到的是不完全的 child 的 子節點
                allContains = false;
            leafs.AddRange(lcas);
        }
        if (allContains)
            return new List<int> { root.val };
        return leafs;
    }
}


