namespace playground;

public class GameOfLife_0289
{
    /// <summary>
    /// https://leetcode.com/problems/game-of-life
    /// </summary>
    public static void GameOfLife(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var lives = new int[m, n];
        var dirs = new (int x, int y)[] { (-1, -1), (-1, 0), (-1, 1), (0, -1), (0, 1), (1, -1), (1, 0), (1, 1) };
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < dirs.Length; k++)
                {
                    var (x, y) = (i + dirs[k].x, j + dirs[k].y);
                    if (x >= 0 && y >= 0 && x < m && y < n && A[x][y] == 1)
                    {
                        lives[i, j]++;
                    }
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1 && (lives[i, j] < 2 || lives[i, j] > 3))
                    A[i][j] = 0;
                else if (A[i][j] == 0 && lives[i, j] == 3)
                    A[i][j] = 1;
            }
        }
    }
}
