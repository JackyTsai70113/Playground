namespace playground.LeetCode._0000_0999;

public class _0861_MatrixScore
{
    /// <summary>
    /// https://leetcode.com/problems/score-after-flipping-matrix
    /// </summary>
    public static int MatrixScore(int[][] A)
    {
        int m = A.Length, n = A[0].Length, res = (1 << (n - 1)) * m;
        for (int j = 1; j < n; j++)
        {
            int count = 0;
            for (int i = 0; i < m; i++)
                count += A[i][0] == A[i][j] ? 1 : 0;
            res += Math.Max(count, m - count) * (1 << (n - j - 1));
        }
        return res;
    }
}
