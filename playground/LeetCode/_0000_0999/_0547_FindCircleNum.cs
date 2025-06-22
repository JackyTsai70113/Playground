using playground.Helpers;

namespace playground.LeetCode._0000_0999;

public class _0547_FindCircleNum
{
    public static int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        var ds = new DisjointSet(n);
        for (int i = 0; i < n; ++i)
            for (int j = i + 1; j < n; ++j)
                if (isConnected[i][j] == 1)
                    ds.Union(i, j);
        var set = new HashSet<int>();
        for (int i = 0; i < isConnected.Length; i++)
        {
            set.Add(ds.Find(i));
        }
        return set.Count;
    }
}
