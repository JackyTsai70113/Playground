namespace playground;

public class IsValidSudoku_0036
{
    /// <summary>
    /// https://leetcode.com/problems/valid-sudoku
    /// </summary>
    public static bool IsValidSudoku(char[][] A)
    {
        var rows = new bool[9, 9];
        var cols = new bool[9, 9];
        var blocks = new bool[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (A[i][j] == '.')
                    continue;
                int x = A[i][j] - '1';
                if (rows[i, x] || cols[j, x] || blocks[i / 3 * 3 + j / 3, x])
                    return false;
                rows[i, x] = true;
                cols[j, x] = true;
                blocks[i / 3 * 3 + j / 3, x] = true;
            }
        }
        return true;
    }
}
