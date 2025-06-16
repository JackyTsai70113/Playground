namespace playground.LeetCode._0000_0999;

public class _0695_MaxAreaOfIsland
{
    public static int MaxAreaOfIsland(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int res = 0;

        int Dfs(int i, int j)
        {
            if (i < 0 || i == m || j < 0 || j == n || A[i][j] != 1)
                return 0;
            A[i][j] = 0;
            int res = 1;
            res += Dfs(i + 1, j);
            res += Dfs(i - 1, j);
            res += Dfs(i, j - 1);
            res += Dfs(i, j + 1);
            return res;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    res = Math.Max(res, Dfs(i, j));
                }
            }
        }
        return res;
    }
}
