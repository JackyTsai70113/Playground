namespace playground.BreadthFirstSearch;

public class ShortestPathAllKeysClass
{
    public static int ShortestPathAllKeys(string[] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var q = new Queue<(int r, int c, int k)>();
        int k = 0;
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (grid[i][j] == '@')
                    q.Enqueue((i, j, 0));
                else if (grid[i][j] >= 'a' && grid[i][j] <= 'f')
                    k = Math.Max(k, grid[i][j] - 'a' + 1);
            }
        }

        var memo = new int[m, n, 1 << k];

        bool isValid(int dist, int r, int c, int mask)
        {
            if (r < 0 || c < 0 || r == m || c == n)
                return false;
            if (grid[r][c] == '#')
                return false;
            if (grid[r][c] >= 'A' && grid[r][c] <= 'F' && ((mask & (1 << (grid[r][c] - 'A'))) == 0))
                return false;
            if (memo[r, c, mask] != 0 && dist + 1 >= memo[r, c, mask])
                return false;
            return true;
        }

        var dirs = new int[] { -1, 0, 1, 0, -1 };
        while (q.Count > 0)
        {
            var (r0, c0, mask) = q.Dequeue();
            for (int i = 0; i < 4; ++i)
            {

                int r = r0 + dirs[i], c = c0 + dirs[i + 1];

                if (isValid(memo[r0, c0, mask], r, c, mask))
                {
                    if (grid[r][c] >= 'a' && grid[r][c] <= 'f')
                    {
                        int newMask = mask | (1 << (grid[r][c] - 'a'));
                        memo[r, c, newMask] = memo[r0, c0, mask] + 1;
                        if (newMask == (1 << k) - 1)
                            return memo[r, c, newMask];
                        q.Enqueue((r, c, newMask));
                    }
                    else
                    {
                        memo[r, c, mask] = memo[r0, c0, mask] + 1;
                        q.Enqueue((r, c, mask));
                    }
                }
            }
        }
        return -1;
    }
}
