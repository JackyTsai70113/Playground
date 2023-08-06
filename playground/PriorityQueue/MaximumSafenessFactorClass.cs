namespace playground.PriorityQueue;

public class MaximumSafenessFactorClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-safest-path-in-a-grid
    /// </summary>
    public static int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        int n = grid.Count;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var factors = GetFactors(grid.ToList());
        if (factors[0][0] == 0 || factors[n - 1][n - 1] == 0)
            return 0;

        PriorityQueue<(int, int), int> pq = new();
        var seen = new bool[n, n];
        pq.Enqueue((0, 0), -factors[0][0]);
        int res = factors[0][0];
        while (pq.Count > 0)
        {
            var (x0, y0) = pq.Dequeue();
            res = Math.Min(res, factors[x0][y0]);
            if (x0 == n - 1 && y0 == n - 1)
                break;
            for (int i = 0; i < 4; i++)
            {
                int x = x0 + dirs[i];
                int y = y0 + dirs[i + 1];
                if (x >= 0 && y >= 0 && x < n && y < n && !seen[x, y])
                {
                    seen[x, y] = true;
                    pq.Enqueue((x, y), -factors[x][y]);
                }
            }
        }

        return res;
    }

    private static int[][] GetFactors(IList<IList<int>> grid)
    {
        int n = grid.Count;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var factors = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            factors[i] = new int[n];
            Array.Fill(factors[i], int.MaxValue);
        }

        var q = new Queue<(int x, int y)>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    factors[i][j] = 0;
                    q.Enqueue((i, j));
                }
            }
        }

        while (q.Count > 0)
        {
            var (x0, y0) = q.Dequeue();
            for (int i = 0; i < 4; ++i)
            {
                int x = x0 + dirs[i];
                int y = y0 + dirs[i + 1];
                if (x >= 0 && y >= 0 && x < n && y < n && factors[x][y] > factors[x0][y0] + 1)
                {
                    factors[x][y] = factors[x0][y0] + 1;
                    q.Enqueue((x, y));
                }
            }
        }
        return factors;
    }
}
