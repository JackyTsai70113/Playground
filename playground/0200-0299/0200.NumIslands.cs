namespace playground;

public class NumIslands0200
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands
    /// </summary>
    public static int NumIslands(char[][] A)
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

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == '2')
                {
                    A[i][j] = '1';
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
