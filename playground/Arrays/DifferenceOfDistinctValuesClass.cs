namespace playground.Arrays
{
    public class DifferenceOfDistinctValuesClass
    {
        /// <summary>
        /// https://leetcode.com/problems/difference-of-number-of-distinct-values-on-diagonals
        /// </summary>
        public static int[][] DifferenceOfDistinctValues(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[][] res = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                res[i] = new int[n];
            }

            void fill(int r, int c)
            {
                Dictionary<int, int> topLeftDict = new(), bottomRightDict = new();
                for (int rr = r, cc = c; rr < m && cc < n; ++rr, ++cc)
                {
                    topLeftDict[grid[rr][cc]] = topLeftDict.TryGetValue(grid[rr][cc], out int val) ? val + 1 : 1;
                }
                for (int rr = r, cc = c; rr < m && cc < n; ++rr, ++cc)
                {
                    topLeftDict[grid[rr][cc]]--;
                    if (topLeftDict[grid[rr][cc]] == 0)
                    {
                        topLeftDict.Remove(grid[rr][cc]);
                    }

                    if (rr != r)
                    {
                        bottomRightDict[grid[rr - 1][cc - 1]] = bottomRightDict.TryGetValue(grid[rr - 1][cc - 1], out int val) ? val + 1 : 1;
                    }

                    res[rr][cc] = Math.Abs(topLeftDict.Keys.Count - bottomRightDict.Keys.Count);
                }
            }
            for (int i = 0; i < n; ++i)
            {
                fill(0, i);
            }

            for (int i = 1; i < m; ++i)
            {
                fill(i, 0);
            }

            return res;
        }
    }
}