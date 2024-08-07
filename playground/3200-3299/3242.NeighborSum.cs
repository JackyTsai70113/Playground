namespace playground;


public class NeighborSum3242
{
    Dictionary<int, int> adj;
    Dictionary<int, int> diag;
    public NeighborSum3242(int[][] A)
    {
        adj = new();
        diag = new();
        int m = A.Length, n = A[0].Length;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                adj[A[i][j]] = i == 0 ? 0 : A[i - 1][j];
                adj[A[i][j]] += j == 0 ? 0 : A[i][j - 1];
                adj[A[i][j]] += i == m - 1 ? 0 : A[i + 1][j];
                adj[A[i][j]] += j == n - 1 ? 0 : A[i][j + 1];

                diag[A[i][j]] = i > 0 && j > 0 ? A[i - 1][j - 1] : 0;
                diag[A[i][j]] += i > 0 && j < n - 1 ? A[i - 1][j + 1] : 0;
                diag[A[i][j]] += i < m - 1 && j > 0 ? A[i + 1][j - 1] : 0;
                diag[A[i][j]] += i < m - 1 && j < n - 1 ? A[i + 1][j + 1] : 0;
            }
        }
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
