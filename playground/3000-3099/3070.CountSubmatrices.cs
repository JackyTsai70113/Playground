namespace playground;

public class CountSubmatrices3070
{
    /// <summary>
    /// https://leetcode.com/problems/count-submatrices-with-top-left-element-and-sum-less-than-k
    /// </summary>
    public static int CountSubmatrices(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length, res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0) grid[i][j] += grid[i - 1][j];
                if (j > 0) grid[i][j] += grid[i][j - 1];
                if (i > 0 && j > 0) grid[i][j] -= grid[i - 1][j - 1];
                if (grid[i][j] <= k) res++;
            }
        }
        return res;
    }
}
