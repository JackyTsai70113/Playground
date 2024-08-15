namespace playground;


public class NeighborSum3242
{
    int m;
    int n;
    int[][] A;
    readonly Dictionary<int, int> adj;
    readonly Dictionary<int, int> diag;
    public NeighborSum3242(int[][] A)
    {
        this.A = A;
        m = A.Length; n = A[0].Length;
        adj = new(); diag = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                AddToAdj(i, j);
                AddToDiag(i, j);
            }
        }
    }

    void AddToAdj(int i, int j)
    {
        adj[A[i][j]] = 0;
        if (i > 0) adj[A[i][j]] += A[i - 1][j];
        if (j > 0) adj[A[i][j]] += A[i][j - 1];
        if (i < m - 1) adj[A[i][j]] += A[i + 1][j];
        if (j < n - 1) adj[A[i][j]] += A[i][j + 1];
    }

    void AddToDiag(int i, int j)
    {
        diag[A[i][j]] = 0;
        if (i > 0 && j > 0) diag[A[i][j]] += A[i - 1][j - 1];
        if (i > 0 && j < n - 1) diag[A[i][j]] += A[i - 1][j + 1];
        if (i < m - 1 && j > 0) diag[A[i][j]] += A[i + 1][j - 1];
        if (i < m - 1 && j < n - 1) diag[A[i][j]] += A[i + 1][j + 1];
    }

    public int AdjacentSum(int value)
    {
        return adj[value];
    }

    public int DiagonalSum(int value)
    {
        return diag[value];
    }
}
