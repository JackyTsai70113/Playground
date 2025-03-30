namespace playground;

public class DistanceLimitedPathsExist1697
{
    /// <summary>
    /// https://leetcode.com/problems/checking-existence-of-edge-length-limited-paths
    /// </summary>
    public static bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
    {
        edgeList = edgeList
            .OrderBy(x => x[2])
            .ToArray();
        var qs = queries
            .Select((x, i) => (p: x[0], q: x[1], limit: x[2], idx: i))
            .OrderBy(y => y.limit)
            .ToArray();

        var ds = new DisjointSet(n);
        var res = new bool[queries.Length];
        int i = 0;
        foreach (var (p, q, limit, idx) in qs)
        {
            for (; i < edgeList.Length && edgeList[i][2] < limit; i++)
            {
                ds.Join(edgeList[i][0], edgeList[i][1]);
            }
            if (ds.Find(p) == ds.Find(q))
            {
                res[idx] = true;
            }
        }
        return res;
    }
}
