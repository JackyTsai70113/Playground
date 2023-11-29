namespace playground;

public class Transpose_0867
{
    public static int[][] Transpose(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var res = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            res[i] = new int[m];
            for (int j = 0; j < m; ++j)
                res[i][j] = A[j][i];
        }
        return res;
    }
}
