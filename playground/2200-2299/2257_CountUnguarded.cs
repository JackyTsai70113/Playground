namespace playground._2200_2299;

public class _2257_CountUnguarded
{
    public static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        int res = m * n - guards.Length - walls.Length;
        int[,] grid = new int[m, n];

        foreach (var guard in guards) grid[guard[0], guard[1]] = 1;
        foreach (var wall in walls) grid[wall[0], wall[1]] = 2;

        for (int i = 0; i < m; i++)
        {
            int before = -1;
            for (int j = 0; j <= n; j++)
            {
                if (j < n && (grid[i, j] != 1 && grid[i, j] != 2)) continue;
                bool guarded = false;
                if (before >= 0 && grid[i, before] == 1 || j < n && grid[i, j] == 1)
                {
                    guarded = true;
                }
                if (guarded)
                {
                    for (int k = before + 1; k < j; k++)
                    {
                        if (grid[i, k] == 0)
                            res--;
                        grid[i, k] = 3;
                    }
                }
                before = j;
            }
        }

        for (int j = 0; j < n; j++)
        {
            int before = -1;
            for (int i = 0; i <= m; i++)
            {
                if (i < m && (grid[i, j] != 1 && grid[i, j] != 2)) continue;
                bool guarded = false;
                if (before >= 0 && grid[before, j] == 1 || i < m && grid[i, j] == 1)
                {
                    guarded = true;
                }
                if (guarded)
                {
                    for (int k = before + 1; k < i; k++)
                    {
                        if (grid[k, j] == 0)
                            res--;
                        grid[k, j] = 3;
                    }
                }
                before = i;
            }
        }

        return res;
    }
}
