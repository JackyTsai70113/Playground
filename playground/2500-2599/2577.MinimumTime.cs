namespace playground;

public class MinimumTime2577
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-visit-a-cell-in-a-grid
    /// </summary>
    public static int MinimumTime(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var pq = new PriorityQueue<(int, int, int), int>();
        if (grid[0][1] <= 1 || grid[1][0] <= 1)
            pq.Enqueue((0, 0, 0), 0);
        var seen = new bool[m, n];
        seen[0, 0] = true;
        while (pq.Count > 0)
        {
            var (x0, y0, t0) = pq.Dequeue();
            if (x0 == m - 1 && y0 == n - 1) return t0;
            for (int i = 0; i < 4; i++)
            {
                var (x, y) = (x0 + dirs[i], y0 + dirs[i + 1]);
                if (x < 0 || y < 0 || x == m || y == n || seen[x, y])
                    continue;
                seen[x, y] = true;
                int wait = (grid[x][y] - t0) % 2 == 0 ? 1 : 0;
                int t = Math.Max(t0 + 1, grid[x][y] + wait);
                pq.Enqueue((x, y, t), t);
            }
        }
        return -1;
    }
}
