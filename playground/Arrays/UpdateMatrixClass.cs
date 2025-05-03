namespace playground.Arrays;

public class UpdateMatrixClass
{
    /// <summary>
    /// https://leetcode.com/problems/01-matrix
    /// </summary>
    public static int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var res = new int[m][];
        for (int i = 0; i < m; i++)
        {
            res[i] = new int[n];
            Array.Fill(res[i], int.MaxValue);
        }

        var seen = new bool[m, n];
        var q = new Queue<(int, int)>();
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (mat[i][j] == 0)
                {
                    seen[i, j] = true;
                    q.Enqueue((i, j));
                }
            }
        }

        int dist = 0;
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                var (x0, y0) = q.Dequeue();
                res[x0][y0] = dist;
                for (int j = 0; j < 4; ++j)
                {
                    int x = x0 + dirs[j], y = y0 + dirs[j + 1];
                    if (x < 0 || y < 0 || x == m || y == n)
                        continue;
                    if (!seen[x, y])
                    {
                        seen[x, y] = true;
                        q.Enqueue((x, y));
                    }
                }
            }
            dist++;
        }
        return res;
    }
}
