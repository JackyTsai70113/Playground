namespace playground.LeetCode._2000_2999;

public class _2658_FindMaxFish
{
    public static int FindMaxFish(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] > 0)
                {
                    res = Math.Max(res, Helper(A, i, j));
                }
            }
        }
        return res;
    }

    public static int Helper(int[][] A, int i, int j)
    {
        int m = A.Length, n = A[0].Length;
        if (i < 0 || j < 0 || i == m || j == n || A[i][j] == 0)
            return 0;
        int res = A[i][j];
        A[i][j] = 0;
        return res + Helper(A, i - 1, j) + Helper(A, i + 1, j) +
            Helper(A, i, j - 1) + Helper(A, i, j + 1);
    }
}
