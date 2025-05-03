namespace playground;

public class _1568_MinDays
{
    int[][] A;
    int m;
    int n;
    public int MinDays(int[][] A)
    {
        this.A = A;
        m = A.Length; n = A[0].Length;
        var deepCopy = DeepCopy();
        var islandCount = IslandCount(deepCopy);
        if (islandCount != 1)
            return 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    deepCopy = DeepCopy();
                    deepCopy[i][j] = 0;
                    islandCount = IslandCount(deepCopy);
                    if (islandCount != 1)
                        return 1;
                }
            }
        }
        return 2;
    }

    int IslandCount(int[][] A)
    {
        var res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    res++;
                    Dfs(A, i, j);
                }
            }
        }
        return res;
    }

    void Dfs(int[][] A, int i, int j)
    {
        if (A[i][j] == 0) return;
        A[i][j] = 0;
        if (i - 1 >= 0) Dfs(A, i - 1, j);
        if (j - 1 >= 0) Dfs(A, i, j - 1);
        if (i + 1 < A.Length) Dfs(A, i + 1, j);
        if (j + 1 < A[0].Length) Dfs(A, i, j + 1);
    }

    int[][] DeepCopy()
    {
        var res = new int[m][];
        for (int i = 0; i < m; i++)
        {
            res[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                res[i][j] = A[i][j];
            }
        }
        return res;
    }
}
