namespace playground._3300_3399;

public class _3393_CountPathsWithXorValue
{
    public static int CountPathsWithXorValue(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;
        var memo = new long[m, n, 16];
        long MOD = (long)1e9 + 7;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0)
                {
                    memo[i, j, grid[0][0]] = 1;
                    continue;
                }
                if (i > 0)
                {
                    for (int l = 0; l < 16; l++)
                    {
                        memo[i, j, l ^ grid[i][j]] = (memo[i, j, l ^ grid[i][j]] + memo[i - 1, j, l]) % MOD;
                    }
                }
                if (j > 0)
                {
                    for (int l = 0; l < 16; l++)
                    {
                        memo[i, j, l ^ grid[i][j]] = (memo[i, j, l ^ grid[i][j]] + memo[i, j - 1, l]) % MOD;
                    }
                }
            }
        }

        return (int)memo[m - 1, n - 1, k];
    }
}
