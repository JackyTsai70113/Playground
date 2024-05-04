namespace playground.UnionFinds;

public class UnionFind
{
    private readonly int[] Groups;
    private readonly int[] Ranks;
    public UnionFind(int n)
    {
        Groups = new int[n];
        Ranks = new int[n];
        for (int i = 0; i < n; ++i)
        {
            Groups[i] = i;
            Ranks[i] = 1;
        }
    }

    /// <summary>
    /// 取得 node 的 group
    /// </summary>
    public int Find(int node)
    {
        if (Groups[node] != node)
        {
            Groups[node] = Find(Groups[node]);
        }
        return Groups[node];
    }

    /// <summary>
    /// 將節點 1 和節點 2 相連
    /// </summary>
    /// <param name="node1">節點 1</param>
    /// <param name="node2">節點 2</param>
    public void Connect(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (group1 == group2) return;
        if (Ranks[group2] > Ranks[group1])
        {
            (group1, group2) = (group2, group1);
        }
        Groups[group2] = group1;
        Ranks[group1] += Ranks[group2];
    }

    /// <summary>
    /// 確認節點 1 和節點 2 是否相連
    /// </summary>
    /// <param name="node1">節點 1</param>
    /// <param name="node2">節點 2</param>
    /// <returns>節點 1 和節點 2 是否相連</returns>
    public bool AreConnected(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        return group1 == group2;
    }

    /// <summary>
    /// 取得該節點的 disjoint group 成員數量
    /// </summary>
    /// <param name="node">節點</param>
    /// <returns>節點的 disjoint group 成員數量</returns>
    public int GetSize(int node)
    {
        return Ranks[Find(node)];
    }

    /// <summary>
    /// 將節點重新放到獨立的 disjoint group
    /// </summary>
    /// <param name="node">節點</param>
    public void Reset(int node)
    {
        int group = Find(node);
        Ranks[group]--;
        Groups[node] = node;
    }
}