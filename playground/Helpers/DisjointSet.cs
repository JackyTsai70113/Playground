namespace playground.Helpers;

public class DisjointSet
{
    public readonly int[] groups;
    public readonly int[] ranks;
    public DisjointSet(int n)
    {
        groups = new int[n];
        ranks = new int[n];
        for (int i = 0; i < n; i++)
        {
            groups[i] = i;
            ranks[i] = 1;
        }
    }

    /// <summary>
    /// 取得 node 的 group
    /// </summary>
    public int Find(int u)
    {
        if (groups[u] == u) return u;
        return groups[u] = Find(groups[u]);
    }

    /// <summary>
    /// 將節點 1 和節點 2 相連
    /// </summary>
    /// <param name="u1">節點 1</param>
    /// <param name="u2">節點 2</param>
    /// <returns>
    /// <c>true</c> if <c>u1</c> is connected to <c>u2</c>;
    /// <c>false</c> if they are already connected.
    /// </returns>
    /// <remarks>將較小的樹附加到較大的樹</remarks>
    public bool Union(int u1, int u2)
    {
        int g1 = Find(u1), g2 = Find(u2);
        if (g1 == g2) return false;
        if (ranks[g1] < ranks[g2]) (g1, g2) = (g2, g1);
        groups[g2] = g1;
        ranks[g1] += ranks[g2];
        return true;
    }
}
