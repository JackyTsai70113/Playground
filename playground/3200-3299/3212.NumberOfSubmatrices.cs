namespace playground;

public class NumberOfSubmatrices3212
{
    /// <summary>
    /// https://leetcode.com/problems/count-submatrices-with-equal-frequency-of-x-and-y
    /// </summary>
    public static int NumberOfSubmatrices(char[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        var memo = new (int x, int y)[m + 1, n + 1];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[i + 1, j + 1] = (
                    memo[i + 1, j].x + memo[i, j + 1].x - memo[i, j].x,
                    memo[i + 1, j].y + memo[i, j + 1].y - memo[i, j].y
                );
                if (A[i][j] == 'X')
                    memo[i + 1, j + 1].x++;
                else if (A[i][j] == 'Y')
                    memo[i + 1, j + 1].y++;
                if (memo[i + 1, j + 1].x == memo[i + 1, j + 1].y &&
                    memo[i + 1, j + 1].x > 0)
                    res++;
            }
        }
        return res;
    }
}
