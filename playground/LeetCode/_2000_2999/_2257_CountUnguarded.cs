namespace playground.LeetCode._2000_2999;

public class _2257_CountUnguarded
{
    const int GUARD = 1;
    const int WALL = 2;
    const int GUARDED = 3;

    public static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        int res = m * n - guards.Length - walls.Length;
        int[,] grid = new int[m, n];

        foreach (var g in guards) grid[g[0], g[1]] = GUARD;
        foreach (var w in walls) grid[w[0], w[1]] = WALL;

        // 掃橫列
        for (int i = 0; i < m; i++)
            ScanLine(grid, ref res, i, n, true);

        // 掃直行
        for (int j = 0; j < n; j++)
            ScanLine(grid, ref res, j, m, false);

        return res;
    }

    private static void ScanLine(int[,] grid, ref int res, int fixedIndex, int len, bool isRow)
    {
        int before = -1;
        for (int i = 0; i <= len; i++)
        {
            int val = i < len ? (isRow ? grid[fixedIndex, i] : grid[i, fixedIndex]) : WALL;

            if (val != GUARD && val != WALL) continue;

            bool hasGuard = (before >= 0 && GetGridValue(grid, fixedIndex, before, isRow) == GUARD)
                         || (i < len && val == GUARD);

            if (hasGuard)
            {
                for (int k = before + 1; k < i; k++)
                {
                    int r = isRow ? fixedIndex : k;
                    int c = isRow ? k : fixedIndex;

                    if (grid[r, c] == 0)
                    {
                        grid[r, c] = GUARDED;
                        res--;
                    }
                }
            }
            before = i;
        }
    }

    private static int GetGridValue(int[,] grid, int fixedIdx, int varIdx, bool isRow)
    {
        return isRow ? grid[fixedIdx, varIdx] : grid[varIdx, fixedIdx];
    }
}
