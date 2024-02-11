namespace playground;

public class CherryPickup1463
{
    /// <summary>
    /// https://leetcode.com/problems/cherry-pickup-ii
    /// </summary>
    public static int CherryPickup(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var dp = new int[m, n, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                for (int k = j + 1; k < n; k++)
                    dp[i, j, k] = -1;
        return Dfs(A, 0, 0, n - 1, dp);
    }
    static int Dfs(int[][] A, int row, int col1, int col2, int[,,] dp)
    {
        if (row == A.Length || col1 < 0 || col1 >= A[0].Length || col2 < 0 || col2 >= A[0].Length || col1 >= col2)
            return 0;
        if (dp[row, col1, col2] != -1)
            return dp[row, col1, col2];
        int next = 0; ;
        for (int i = col1 - 1; i <= col1 + 1; i++)
            for (int j = Math.Max(i + 1, col2 - 1); j <= col2 + 1; j++)
                next = Math.Max(next, Dfs(A, row + 1, i, j, dp));
        return dp[row, col1, col2] = A[row][col1] + A[row][col2] + next;
    }
}
