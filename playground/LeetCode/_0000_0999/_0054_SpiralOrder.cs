namespace playground.LeetCode._0000_0999;

public class _0054_SpiralOrder
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix
    /// </summary>
    public static IList<int> SpiralOrder(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        int m0 = 0, m1 = m - 1, n0 = 0, n1 = n - 1;
        int i = 0, j = -1, dir = 0;
        var dirs = new (int x, int y)[] { (0, 1), (1, 0), (0, -1), (-1, 0) };
        var res = new List<int>(m * n);
        while (res.Count < m * n)
        {
            var (x, y) = (i + dirs[dir].x, j + dirs[dir].y);
            if (x < m0 || y < n0 || x > m1 || y > n1)
            {
                if (x < m0)
                    n0++;
                else if (y < n0)
                    m1--;
                else if (x > m1)
                    n1--;
                else if (y > n1)
                    m0++;
                dir = (dir + 1) % dirs.Length;
                (x, y) = (i + dirs[dir].x, j + dirs[dir].y);
            }
            (i, j) = (x, y);
            res.Add(A[x][y]);
        }
        return res;
    }
}
