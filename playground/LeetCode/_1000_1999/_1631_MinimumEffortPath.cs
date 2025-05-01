namespace playground._1600_1699;

public class _1631_MinimumEffortPath_cs
{
    public static int MinimumEffortPath(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var effort = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                effort[i, j] = int.MaxValue;
        effort[0, 0] = 0;
        var pq = new PriorityQueue<(int r, int c), int>();
        pq.Enqueue((0, 0), 0);
        var dirs = new int[] { 1, 0, -1, 0, 1 };
        while (pq.Count > 0)
        {
            var (r, c) = pq.Dequeue();
            if (r == m - 1 && c == n - 1)
                break;
            for (int i = 0; i < 4; i++)
            {
                var rr = r + dirs[i];
                var cc = c + dirs[i + 1];
                if (rr < 0 || cc < 0 || rr == m || cc == n ||
                    effort[rr, cc] <= Math.Max(effort[r, c], Math.Abs(A[r][c] - A[rr][cc])))
                    continue;
                effort[rr, cc] = Math.Max(effort[r, c], Math.Abs(A[r][c] - A[rr][cc]));
                pq.Enqueue((rr, cc), effort[rr, cc]);
            }
        }
        return effort[m - 1, n - 1];
    }
}