namespace playground.LeetCode._0000_0999;

public class _0221_MaximalSquare
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-square
    /// </summary> 
    public static int MaximalSquare(char[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length, sideMax = 0;
        var memo = new int[m + 1, n + 1];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == '1')
                {
                    memo[i + 1, j + 1] = Math.Min(memo[i, j], Math.Min(memo[i + 1, j], memo[i, j + 1])) + 1;
                    sideMax = Math.Max(sideMax, memo[i + 1, j + 1]);
                }
            }
        }
        return sideMax * sideMax;
    }
}
