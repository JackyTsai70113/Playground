namespace playground;

public class _3239_MinFlips
{
    public static int MinFlips(int[][] A) {
        int m = A.Length, n = A[0].Length;
        int row = 0, col = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                if (A[i][j] != A[i][^(j + 1)])
                    row++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                if (A[j][i] != A[^(j + 1)][i])
                    col++;
            }
        }
        return Math.Min(row, col);
    }
}
