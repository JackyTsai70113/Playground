namespace playground.LeetCode._0000_0999;

public class _0064_MinPathSum
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum
    /// </summary>
    public static int MinPathSum(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var A = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = grid[i][j];
                if (i != 0 && j != 0)
                    A[i, j] += Math.Min(A[i - 1, j], A[i, j - 1]);
                else if (i != 0)
                    A[i, j] += A[i - 1, j];
                else if (j != 0)
                    A[i, j] += A[i, j - 1];
            }
        }
        return A[m - 1, n - 1];
    }
}
