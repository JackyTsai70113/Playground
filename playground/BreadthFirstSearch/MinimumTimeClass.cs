namespace playground.BreadthFirstSearch;

public class MinimumTimeClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-visit-a-cell-in-a-grid
    /// </summary>
    public static int MinimumTime(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var pq = new PriorityQueue<(int r, int c, int t), int>();
        int[,] time = new int[m, n];

        if (grid[0][1] <= 1 || grid[1][0] <= 1)
        {
            pq.Enqueue((0, 0, 0), 0);
            for (int i = 0; i < m; i++)
                for (var j = 0; j < n; j++)
                    time[i, j] = int.MaxValue;
        }
        void dfs(int r, int c, int tStart)
        {
            if (r < 0 || c < 0 || r == m || c == n || tStart + 1 >= time[r, c])
                return;
            int tEnd;
            if (grid[r][c] < tStart + 1)
                tEnd = tStart + 1;
            else if ((grid[r][c] - tStart) % 2 == 0)
                tEnd = grid[r][c] + 1;
            else
                tEnd = grid[r][c];
            pq.Enqueue((r, c, tEnd), tEnd);
            time[r, c] = tEnd;
        }
        while (pq.Count > 0)
        {
            var (r, c, t) = pq.Dequeue();
            if (r == m - 1 && c == n - 1)
                return t;
            dfs(r + 1, c, t);
            dfs(r, c - 1, t);
            dfs(r - 1, c, t);
            dfs(r, c + 1, t);
        }
        return -1;
    }
}
