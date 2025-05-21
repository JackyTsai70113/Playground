namespace playground.LeetCode._0000_0999;

public class _0073_SetZeroes
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

    public static void SetZeroes_O_1_Space(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        bool col0 = false;
        for (int i = 0; i < m; i++)
        {
            if (A[i][0] == 0) col0 = true;
            for (int j = 1; j < n; j++)
            {
                if (A[i][j] == 0)
                {
                    A[i][0] = A[0][j] = 0;
                }
            }
        }

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 1; j--)
            {
                if (A[i][0] == 0 || A[0][j] == 0)
                    A[i][j] = 0;
            }
            if (col0) A[i][0] = 0;
        }
    }
}
