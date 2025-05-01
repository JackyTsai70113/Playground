namespace playground;

public class _3286_FindSafeWalk
{
    public static bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        int m = grid.Count, n = grid[0].Count;
        int[] dirs = new int[] { 0, 1, 0, -1, 0 };
        var dp = new int[m, n];
        var q = new PriorityQueue<(int, int), int>();
        int curHealth = health + (grid[0][0] == 1 ? -1 : 0);
        if (curHealth > 0)
        {
            dp[0, 0] = curHealth;
            q.Enqueue((0, 0), dp[0, 0]);
        }
        while (q.Count > 0)
        {
            var (x, y) = q.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int xx = x + dirs[i], yy = y + dirs[i + 1];
                if (xx < 0 || yy < 0 || xx == m || yy == n)
                    continue;
                curHealth = dp[x, y] + (grid[xx][yy] == 1 ? -1 : 0);
                if (curHealth > dp[xx, yy])
                {
                    dp[xx, yy] = curHealth;
                    q.Enqueue((xx, yy), dp[xx, yy]);
                }
            }
        }
        return dp[m - 1, n - 1] > 0;
    }
}