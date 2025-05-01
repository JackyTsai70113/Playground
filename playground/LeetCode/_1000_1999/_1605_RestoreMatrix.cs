namespace playground;

public class _1605_RestoreMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums
    /// </summary>
    public static int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int m = rowSum.Length, n = colSum.Length;
        var res = new int[m][];
        int j = 0;
        for (int i = 0; i < m; i++)
        {
            res[i] = new int[n];
            while (j < n)
            {
                if(rowSum[i] == 0) break;
                res[i][j] = Math.Min(rowSum[i], colSum[j]);
                rowSum[i] -= res[i][j];
                colSum[j] -= res[i][j];
                if (colSum[j] == 0) j++;
            }
        }
        return res;
    }
}
