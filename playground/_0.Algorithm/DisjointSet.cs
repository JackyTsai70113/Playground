namespace playground;

public class DisjointSet
{
    public readonly int[] Groups;
    public readonly int[] Ranks;
    public DisjointSet(int n)
    {
        Groups = Enumerable.Range(0, n).ToArray();
        Ranks = Enumerable.Repeat(1, n).ToArray();
    }

    /// <summary>
    /// 取得 node 的 group
    /// </summary>
    public int Find(int node)
    {
        if (node != Groups[node])
            Groups[node] = Find(Groups[node]);
        return Groups[node];
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
