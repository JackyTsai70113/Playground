namespace playground.LeetCode._0000_0999;

public class _0051_SolveNQueens
{
    public static IList<IList<string>> SolveNQueens(int n)
    {
        var validRow = new bool[n];
        var validDiffDiag = new bool[2 * (n - 1) + 1];
        var validSumDiag = new bool[2 * (n - 1) + 1];

        var result = new List<IList<string>>();
        var board = new char[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = new char[n];
            Array.Fill(board[i], '.');
        }

        void Dfs(int row)
        {
            if (row == n)
            {
                var rows = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    rows.Add(new string(board[i]));
                }
                result.Add(rows);
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (validRow[col] || validDiffDiag[row + n - col - 1] || validSumDiag[row + col])
                    continue;

                validRow[col] = true;
                validDiffDiag[row + n - col - 1] = true;
                validSumDiag[row + col] = true;
                board[row][col] = 'Q';

                Dfs(row + 1);

                board[row][col] = '.';
                validRow[col] = false;
                validDiffDiag[row + n - col - 1] = false;
                validSumDiag[row + col] = false;
            }
        }
        Dfs(0);
        return result;
    }
}
