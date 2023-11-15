namespace playground;

public class FindChampion_2923
{
    /// <summary>
    /// https://leetcode.com/problems/find-champion-i
    /// </summary>
    public static int FindChampion(int[][] grid)
    {
        int n = grid.Length, res = 0;
        for (int i = 0; i < n; ++i)
        {
            int j = 0;
            for (; j < n; ++j)
            {
                if (i != j && grid[i][j] == 0)
                    break;
            }
            if (j == n)
            {
                res = i;
                break;
            }
        }
        return res;
    }
}
