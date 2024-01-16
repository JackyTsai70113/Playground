namespace playground;

public class ShortestPathAllKeys0864
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-path-to-get-all-keys
    /// </summary>
    public static int ShortestPathAllKeys(string[] grid)
    {
        Queue<(int, int, int)> q = new();
        HashSet<(int, int, int)> seen = new();
        int m = grid.Length, n = grid[0].Length, step = 0;
        var dirs = new int[,] { { 1, 0 }, { -1, 0 }, { 0, -1 }, { 0, 1 } };
        int starti = -1, startj = -1, targetKey = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '@')
                {
                    (starti, startj) = (i, j);
                }
                else if ('a' <= grid[i][j] && grid[i][j] <= 'f')
                {
                    targetKey = (targetKey << 1) + 1;
                }
            }
        }
        q.Enqueue((starti, startj, 0));
        seen.Add((starti, startj, 0));
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; i--)
            {
                var (x0, y0, key) = q.Dequeue();
                if (key == targetKey) return step;
                for (int j = 0; j < 4; j++)
                {
                    var (x, y, newKey) = (x0 + dirs[j, 0], y0 + dirs[j, 1], key);
                    if (!IsValid(grid, x, y, key)) continue;
                    if ('a' <= grid[x][y] && grid[x][y] <= 'f')
                        newKey |= 1 << (grid[x][y] - 'a');
                    if (seen.Contains((x, y, newKey)))
                        continue;
                    q.Enqueue((x, y, newKey));
                    seen.Add((x, y, newKey));
                }
            }
            step++;
        }
        return -1;
    }

    private static bool IsValid(string[] grid, int x, int y, int key)
    {
        int m = grid.Length, n = grid[0].Length;
        if (x < 0 || y < 0 || x == m || y == n || grid[x][y] == '#')
            return false;
        if ('A' <= grid[x][y] && grid[x][y] <= 'F' &&
            (key & (1 << (grid[x][y] - 'A'))) == 0)
            return false;
        return true;
    }
}
