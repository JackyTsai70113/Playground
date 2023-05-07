namespace playground.DynamicPrograming;

public class MinimumVisitedCellsClass
{
    public static int MinimumVisitedCells(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length, step = 0;
        int[] maxRows = new int[n], maxCols = new int[m];
        List<(int x, int y)> l1 = new()
        {
            (x: 0, y:0)
        }, l2 = new();
        while (l1.Count > 0)
        {
            ++step;
            foreach (var (x, y) in l1)
            {
                if (x == m - 1 && y == n - 1)
                    return step;
                for (int k = maxRows[y] + 1; k < m && k <= grid[x][y] + x; ++k)
                    l2.Add((k, y));
                for (int k = maxCols[x] + 1; k < n && k <= grid[x][y] + y; ++k)
                    l2.Add((x, k));
                maxRows[y] = Math.Max(maxRows[y], grid[x][y] + x);
                maxCols[x] = Math.Max(maxCols[x], grid[x][y] + y);
            }
            (l1, l2) = (l2, l1);
            l2.Clear();
        }

        return -1;
    }
}
