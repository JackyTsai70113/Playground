namespace playground.LeetCode._0000_0999;

public class _0200_NumIslands
{
    public static int NumIslands(char[][] A)
    {
        int rows = A.Length, cols = A[0].Length, res = 0;
        var dirs = new int[] { 1, 0, -1, 0, 1 };

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i][j] == '1')
                {
                    res++;
                    var q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    A[i][j] = '2';
                    while (q.Count > 0)
                    {
                        var (r0, c0) = q.Dequeue();
                        for(int idx = 0; idx < 4; idx++){
                            int r = r0 + dirs[idx], c = c0 + dirs[idx + 1];
                            if (r < 0 || c < 0 || r == rows || c == cols || A[r][c] != '1')
                                continue;
                            q.Enqueue((r, c));
                            A[r][c] = '2';
                        }
                    }
                }
            }
        }
        return res;
    }

    public static int NumIslands_DFS(char[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == '1')
                {
                    Dfs(A, i, j);
                    res++;
                }
            }
        }

        return res;
    }

    static void Dfs(char[][] A, int r, int c)
    {
        if (r < 0 || c < 0 || r == A.Length || c == A[0].Length || A[r][c] != '1')
            return;
        A[r][c] = '2';
        Dfs(A, r + 1, c);
        Dfs(A, r - 1, c);
        Dfs(A, r, c + 1);
        Dfs(A, r, c - 1);
    }
}
