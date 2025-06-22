using playground.Helpers;

namespace playground.LeetCode._0000_0999;

public class _0947_RemoveStones
{
    public static int RemoveStones(int[][] A)
    {
        int n = A.Length;
        var ds = new DisjointSet(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (A[i][0] == A[j][0] || A[i][1] == A[j][1])
                    ds.Union(i, j);
            }
        }
        int groupsCount = 0;
        for (int i = 0; i < n; i++)
            if (ds.groups[i] == i)
                groupsCount++;
        return n - groupsCount;
    }
}
