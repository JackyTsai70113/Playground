namespace playground;

public class _3122_MinimumOperations
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-satisfy-conditions
    /// </summary>
    public static int MinimumOperations(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var memo = new int[n, 10];
        for (int j = 0; j < n; j++)
        {
            for (int target = 0; target < 10; target++)
            {
                memo[j, target] = m;
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[j, grid[i][j]]--;
            }
        }
        for (int j = 1; j < n; j++)
        {
            for (int target = 0; target < 10; target++)
            {
                int min = int.MaxValue;
                for (int pre = 0; pre < 10; pre++)
                {
                    if (pre != target)
                        min = Math.Min(min, memo[j - 1, pre]);
                }
                memo[j, target] += min;
            }
        }
        int res = int.MaxValue;
        for (int target = 0; target < 10; target++)
        {
            res = Math.Min(res, memo[n - 1, target]);
        }
        return res;
    }
}