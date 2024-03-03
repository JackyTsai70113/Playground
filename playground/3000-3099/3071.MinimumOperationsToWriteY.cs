namespace playground;

public class MinimumOperationsToWriteY3071
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-write-the-letter-y-on-a-grid
    /// </summary>
    public static int MinimumOperationsToWriteY(int[][] grid)
    {
        int n = grid.Length;
        int[] a = new int[3], b = new int[3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= n / 2 && (i == j || i + j == n - 1))
                {
                    a[grid[i][j]]++;
                }
                else if (i > n / 2 && j == n / 2)
                {
                    a[grid[i][j]]++;
                }
                else
                {
                    b[grid[i][j]]++;
                }
            }
        }
        var res = int.MaxValue;
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                if (i != j)
                {
                    var temp = a[(i + 1) % 3] + a[(i + 2) % 3] + b[(j + 1) % 3] + b[(j + 2) % 3];
                    res = Math.Min(res, temp);
                }
            }
        }
        return res;
    }
}
