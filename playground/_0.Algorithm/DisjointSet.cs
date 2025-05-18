namespace playground._0.Algorithm;

public class DisjointSet
{
    public readonly int[] gs;
    public readonly int[] rs;
    public DisjointSet(int n)
    {
        gs = Enumerable.Range(0, n).ToArray();
        rs = Enumerable.Repeat(1, n).ToArray();
    }

    /// <summary>
    /// 取得 node 的 group
    /// </summary>
    public int Find(int u)
    {
        return gs[u] = gs[u] == u ? u : Find(gs[u]);
    }

    /// <summary>
    /// 將節點 1 和節點 2 相連
    /// </summary>
    /// <param name="u1">節點 1</param>
    /// <param name="u2">節點 2</param>
    /// <returns>`true` if `u1` is connected to `u2`; `false` if they are already connected.</returns>
    /// <remarks>將較小的樹附加到較大的樹</remarks>
    public bool Join(int u1, int u2)
    {
        int g1 = Find(u1), g2 = Find(u2);
        if (g1 == g2) return false;
        if (rs[g1] < rs[g2]) (g1, g2) = (g2, g1);
        gs[g2] = g1;
        rs[g1] += rs[g2];
        return true;
    }
}
