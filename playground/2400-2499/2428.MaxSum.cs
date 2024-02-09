namespace playground;

public class MaxSum2428
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-an-hourglass
    /// </summary>
    public static int MaxSum(int[][] g)
    {
        int m = g.Length, n = g[0].Length, res = 0;
        for (int row = 0; row < m - 2; ++row)
        {
            for (int col = 0; col < n - 2; ++col)
            {
                int sum = g[row + 1][col + 1];
                for (int c = col; c < col + 3; ++c)
                {
                    sum += g[row][c];
                    sum += g[row + 2][c];
                }
                res = Math.Max(res, sum);
            }
        }
        return res;
    }
}