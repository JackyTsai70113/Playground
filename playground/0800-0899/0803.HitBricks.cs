namespace playground;

public class HitBricks0803
{
    /// <summary>
    /// https://leetcode.com/problems/bricks-falling-when-hit
    /// </summary>
    public static int[] HitBricks(int[][] grid, int[][] hits)
    {
        int m = grid.Length, n = grid[0].Length;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var A = grid.Select(x => x.ToArray()).ToArray();
        foreach (var hit in hits)
            A[hit[0]][hit[1]] = 0;

        var ds = new DisjointSet(m * n + 1);
        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (A[r][c] == 0)
                    continue;
                int node = r * n + c;
                if (r == 0)
                    ds.Join(node, m * n);
                if (r > 0 && A[r - 1][c] == 1)
                    ds.Join(node, (r - 1) * n + c);
                if (c > 0 && A[r][c - 1] == 1)
                    ds.Join(node, r * n + c - 1);
            }
        }

        void move(int x0, int y0)
        {
            int node = x0 * n + y0;
            for (int i = 0; i < 4; ++i)
            {
                int x = x0 + dirs[i], y = y0 + dirs[i + 1];
                if (x >= 0 && y >= 0 && x < m && y < n && A[x][y] == 1)
                {
                    ds.Join(node, x * n + y);
                }
            }
        }
        var res = new int[hits.Length];
        for (int t = hits.Length - 1; t >= 0; --t)
        {
            int x0 = hits[t][0], y0 = hits[t][1];
            if (grid[x0][y0] == 0)
                continue;

            var preCount = ds.rs[ds.Find(m * n)];
            A[x0][y0] = 1;
            move(x0, y0);
            if (x0 == 0) ds.Join(x0 * n + y0, m * n);
            res[t] = Math.Max(0, ds.rs[ds.Find(m * n)] - preCount - 1);
        }
        return res;
    }
}
