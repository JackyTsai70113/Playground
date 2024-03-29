namespace playground.UnionFinds;

public class HitBricks0803
{
    /// <summary>
    /// https://leetcode.com/problems/bricks-falling-when-hit
    /// </summary>
    public static int[] HitBricks(int[][] grid, int[][] hits)
    {
        int R = grid.Length, C = grid[0].Length;
        int[] drs = new int[] { 1, 0, -1, 0 };
        int[] dcs = new int[] { 0, 1, 0, -1 };

        var A = grid.Select(x => x.ToArray()).ToArray();
        foreach (var hit in hits)
        {
            A[hit[0]][hit[1]] = 0;
        }

        var uf = new UnionFind(R * C + 1);
        for (int r = 0; r < R; r++)
        {
            for (int c = 0; c < C; c++)
            {
                if (A[r][c] == 0)
                    continue;
                int node = r * C + c;
                if (r == 0)
                    uf.Connect(node, R * C);
                if (r > 0 && A[r - 1][c] == 1)
                    uf.Connect(node, (r - 1) * C + c);
                if (c > 0 && A[r][c - 1] == 1)
                    uf.Connect(node, r * C + c - 1);
            }
        }

        void f(int node, int x0, int y0)
        {
            for (int i = 0; i < 4; ++i)
            {
                int x = x0 + drs[i], y = y0 + dcs[i];
                if (x >= 0 && y >= 0 && x < R && y < C && A[x][y] == 1)
                {
                    uf.Connect(node, x * C + y);
                }
            }
        }
        var res = new int[hits.Length];
        for (int t = hits.Length - 1; t >= 0; --t)
        {
            int x0 = hits[t][0], y0 = hits[t][1];
            if (grid[x0][y0] == 0)
                continue;

            var preCount = uf.GetSize(R * C);
            A[x0][y0] = 1;
            int node = x0 * C + y0;
            f(node, x0, y0);
            if (x0 == 0) uf.Connect(node, R * C);
            res[t] = Math.Max(0, uf.GetSize(R * C) - preCount - 1);
        }
        return res;
    }
}
