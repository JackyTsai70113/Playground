namespace playground;

public class _2290_MinimumObstacles_cs
{
    public static int MinimumObstacles(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var obs = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                obs[i, j] = int.MaxValue;
            }
        }
        obs[0, 0] = 0;
        var pq = new PriorityQueue<(int x, int y), int>();
        pq.Enqueue((0, 0), 0);
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        while (pq.Count > 0)
        {
            var (x, y) = pq.Dequeue();
            if (x == m - 1 && y == n - 1)
            {
                break;
            }
            for (int i = 0; i < 4; i++)
            {
                int xx = x + dirs[i];
                int yy = y + dirs[i + 1];
                if (xx >= 0 && xx < m && yy >= 0 && yy < n && obs[x, y] + A[xx][yy] < obs[xx, yy])
                {
                    obs[xx, yy] = obs[x, y] + A[xx][yy];
                    pq.Enqueue((xx, yy), obs[xx, yy]);
                }
            }
        }
        return obs[m - 1, n - 1];
    }
}
