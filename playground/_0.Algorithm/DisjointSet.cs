namespace playground;

public class DisjointSet
{
    private readonly int[] Groups;
    private readonly int[] Ranks;
    public DisjointSet(int n)
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
        return Groups[node] = Groups[node] == node ? node : Find(Groups[node]);
    }

    /// <summary>
    /// 將節點 1 和節點 2 相連
    /// </summary>
    /// <param name="node1">節點 1</param>
    /// <param name="node2">節點 2</param>
    /// <returns>`true` if `node1` is connected to `node2`; `false` if they are already connected.</returns>
    public bool Union(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (group1 == group2) return false;
        if (Ranks[group2] > Ranks[group1])
        {
            (group1, group2) = (group2, group1);
        }
        Groups[group2] = group1;
        Ranks[group1] += Ranks[group2];
        return true;
    }
}
