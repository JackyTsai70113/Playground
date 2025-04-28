namespace playground;

public class SetZeroes_0073
{
    public static void SetZeroes(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        bool[] rows = new bool[m], cols = new bool[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 0)
                    rows[i] = cols[j] = true;
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (rows[i] || cols[j])
                    A[i][j] = 0;
            }
        }
    }
}
