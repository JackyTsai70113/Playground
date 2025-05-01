namespace playground.LeetCode._0000_0999;

public class _0407_TrapRainWater
{
    public static int TrapRainWater(int[][] map)
    {
        int m = map.Length, n = map[0].Length;
        if (m < 3 || n < 3)
            return 0;
        var pq = new PriorityQueue<(int x, int y), int>();
        var seen = new bool[m, n];
        for (int i = 0; i < m; i++)
        {
            pq.Enqueue((i, 0), map[i][0]);
            pq.Enqueue((i, n - 1), map[i][n - 1]);
            seen[i, 0] = seen[i, n - 1] = true;
        }
        for (int i = 1; i < n - 1; i++)
        {
            pq.Enqueue((0, i), map[0][i]);
            pq.Enqueue((m - 1, i), map[m - 1][i]);
            seen[0, i] = seen[m - 1, i] = true;
        }
        int res = 0;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        while (pq.Count > 0)
        {
            var (x, y) = pq.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int xx = x + dirs[i], yy = y + dirs[i + 1];
                if (xx < 0 || xx == m || yy < 0 || yy == n || seen[xx, yy])
                    continue;
                seen[xx, yy] = true;
                int target = Math.Max(map[x][y], map[xx][yy]);
                res += target - map[xx][yy];
                map[xx][yy] = target;
                pq.Enqueue((xx, yy), map[xx][yy]);
            }
        }
        return res;
    }
}
