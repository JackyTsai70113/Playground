namespace playground.Arrays;

public class MinimumMovesClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-spread-stones-over-grid/
    /// </summary>
    public static int MinimumMoves(int[][] A)
    {
        var empty = 0;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (A[i][j] == 0)
                    empty++;
            }
        }
        if (empty == 0)
            return 0;
        var res = int.MaxValue;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (A[i][j] != 0)
                    continue;
                for (int ii = 0; ii < 3; ++ii)
                {
                    for (int jj = 0; jj < 3; ++jj)
                    {
                        if (A[ii][jj] <= 1)
                            continue;
                        A[i][j]++;
                        A[ii][jj]--;
                        var count = Math.Abs(i - ii) + Math.Abs(j - jj);
                        res = Math.Min(res, count + MinimumMoves(A));
                        A[i][j]--;
                        A[ii][jj]++;
                    }
                }
            }
        }
        return res;
    }
}
