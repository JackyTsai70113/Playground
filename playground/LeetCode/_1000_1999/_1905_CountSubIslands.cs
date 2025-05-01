namespace playground;

public class _1905_CountSubIslands
{
    public static int CountSubIslands(int[][] A1, int[][] A2)
    {
        int m = A1.Length, n = A1[0].Length, res = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A2[i][j] == 1 && Dfs(A1, A2, i, j))
                {
                    res++;
                }
            }
        }
        return res;
    }

    static bool Dfs(int[][] A1, int[][] A2, int i, int j)
    {
        if (i < 0 || j < 0 || i == A2.Length || j == A2[0].Length || A2[i][j] != 1)
            return true;
        A2[i][j] = 0;
        bool a = Dfs(A1, A2, i - 1, j);
        bool b = Dfs(A1, A2, i + 1, j);
        bool c = Dfs(A1, A2, i, j - 1);
        bool d = Dfs(A1, A2, i, j + 1);
        bool e = A1[i][j] == 1;
        return a && b && c && d && e;
    }
}
