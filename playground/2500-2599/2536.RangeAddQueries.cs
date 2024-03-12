namespace playground;

public class RangeAddQueries2536
{
    /// <summary>
    /// https://leetcode.com/problems/increment-submatrices-by-one
    /// </summary>
    public static int[][] RangeAddQueries(int n, int[][] queries)
    {
        var res = new int[n][];
        for (int i = 0; i < n; ++i)
            res[i] = new int[n];
        foreach (var q in queries)
        {
            int r1 = q[0], c1 = q[1], r2 = q[2], c2 = q[3];
            for (int i = r1; i <= r2; ++i)
            {
                res[i][c1]++;
                if (c2 + 1 < n)
                    res[i][c2 + 1]--;
                else if (i + 1 < n)
                    res[i + 1][0]--;
            }
        }
        for (int i = 0, count = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                count += res[i][j];
                res[i][j] = count;
            }
        }
        return res;
    }
}
