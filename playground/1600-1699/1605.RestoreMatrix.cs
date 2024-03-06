namespace playground;

public class RestoreMatrix1605
{
    /// <summary>
    /// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums
    /// </summary>
    public static int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int m = rowSum.Length, n = colSum.Length;
        var res = new int[m][];
        for (int i = 0; i < m; i++)
            res[i] = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                res[i][j] = Math.Min(rowSum[i], colSum[j]);
                rowSum[i] -= res[i][j];
                colSum[j] -= res[i][j];
            }
        }
        return res;
    }
}
