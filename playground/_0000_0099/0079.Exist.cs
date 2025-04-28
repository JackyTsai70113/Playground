namespace playground;

public class Exist0079
{
    /// <summary>
    /// https://leetcode.com/problems/word-search
    /// </summary>
    public static bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
                if (Bt(board, word, 0, i, j))
                    return true;
        return false;
    }

    public static bool Bt(char[][] board, string word, int start, int r, int c)
    {
        if (start == word.Length)
            return true;
        if (r < 0 || c < 0 || r == board.Length || c == board[0].Length ||
            board[r][c] != word[start])
            return false;
        var oldChar = board[r][c];
        board[r][c] = default;
        var res = Bt(board, word, start + 1, r - 1, c) ||
            Bt(board, word, start + 1, r + 1, c) ||
            Bt(board, word, start + 1, r, c - 1) ||
            Bt(board, word, start + 1, r, c + 1);
        board[r][c] = oldChar;
        return res;
    }
}
