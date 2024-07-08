namespace playground;

public class NumberOfSubmatrices3212
{
    /// <summary>
    /// https://leetcode.com/problems/count-submatrices-with-equal-frequency-of-x-and-y
    /// </summary>
    public static int NumberOfSubmatrices(char[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        var memo = new (int x, int y)[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0)
                {
                    if (A[i][j] == 'X')
                        memo[i, j] = (1, 0);
                    else if (A[i][j] == 'Y')
                        memo[i, j] = (0, 1);
                    else
                        memo[i, j] = (0, 0);
                }
                else if (i == 0)
                {
                    var (x, y) = memo[i, j - 1];
                    if (A[i][j] == 'X')
                        memo[i, j] = (x + 1, y);
                    else if (A[i][j] == 'Y')
                        memo[i, j] = (x, y + 1);
                    else
                        memo[i, j] = (x, y);
                }
                else if (j == 0)
                {
                    var (x, y) = memo[i - 1, j];
                    if (A[i][j] == 'X')
                        memo[i, j] = (x + 1, y);
                    else if (A[i][j] == 'Y')
                        memo[i, j] = (x, y + 1);
                    else
                        memo[i, j] = (x, y);
                }
                else
                {
                    var (x1, y1) = memo[i - 1, j - 1];
                    var (x2, y2) = memo[i - 1, j];
                    var (x3, y3) = memo[i, j - 1];
                    if (A[i][j] == 'X')
                        memo[i, j] = (x2 + x3 - x1 + 1, y2 + y3 - y1);
                    else if (A[i][j] == 'Y')
                        memo[i, j] = (x2 + x3 - x1, y2 + y3 - y1 + 1);
                    else
                        memo[i, j] = (x2 + x3 - x1, y2 + y3 - y1);
                }
                if (memo[i, j].x == memo[i, j].y && memo[i, j].x > 0)
                    res++;
            }
        }
        return res;
    }
}
