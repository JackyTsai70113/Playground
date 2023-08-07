namespace playground.PriorityQueues;

public class MinimumEffortPathClass
{
    public static int MinimumEffortPath(int[][] A)
    {
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        int m = A.Length, n = A[0].Length;
        var efforts = new int[m, n];
        for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < A[0].Length; j++)
                efforts[i, j] = int.MaxValue;

        efforts[0, 0] = 0;
        var pq = new PriorityQueue<(int, int), int>();
        pq.Enqueue((0, 0), efforts[0, 0]);
        while (true)
        {
            var (x0, y0) = pq.Dequeue();
            if (x0 == m - 1 && y0 == n - 1)
                break;
            for (int i = 0; i < 4; ++i)
            {
                var (x, y) = (x0 + dirs[i], y0 + dirs[i + 1]);
                if (x >= 0 && y >= 0 && x < m && y < n)
                {
                    int newDist = Math.Max(efforts[x0, y0], Math.Abs(A[x][y] - A[x0][y0]));
                    if (efforts[x, y] > newDist)
                    {
                        efforts[x, y] = newDist;
                        pq.Enqueue((x, y), efforts[x, y]);
                    }
                }
            }
        }
        return efforts[m - 1, n - 1];
    }
}
