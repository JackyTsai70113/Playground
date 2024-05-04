namespace playground;

public class FindCircleNum0547
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-provinces
    /// </summary>
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
