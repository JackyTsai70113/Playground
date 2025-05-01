namespace playground;

public class _3128_NumberOfRightTriangles
{
    /// <summary>
    /// https://leetcode.com/problems/right-triangles
    /// </summary>
    public static long NumberOfRightTriangles(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int[] row = new int[m], col = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    row[i]++;
                    col[j]++;
                }
            }
        }
        long res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    res += (row[i] - 1) * (col[j] - 1);
                }
            }
        }
        return res;
    }
}
