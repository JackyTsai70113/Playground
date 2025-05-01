namespace playground.LeetCode._0000_0999;

public class _0212_FindWords
{
    /// <summary>
    /// https://leetcode.com/problems/word-search-ii
    /// </summary>
    public static IList<string> FindWords(char[][] board, string[] words)
    {
        var root = new TrieNode<bool>(false, new TrieNode<bool>[26]);
        foreach (var word in words)
            Insert(root, word);
        int m = board.Length, n = board[0].Length;
        var res = new List<string>();
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                Bt(board, root, i, j, string.Empty, res);
        return res;
    }

    private static void Insert(TrieNode<bool> node, string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (node.children[word[i] - 'a'] == null)
                node.children[word[i] - 'a'] = new TrieNode<bool>(false, new TrieNode<bool>[26]);
            node = node.children[word[i] - 'a'];
        }
        node.val = true;
    }

    private static void Bt(char[][] board, TrieNode<bool> node, int r, int c, string path, List<string> res)
    {
        if (node.val)
        {
            res.Add(path);
            node.val = false;
        }
        if (r < 0 || c < 0 || r == board.Length || c == board[0].Length ||
            board[r][c] == '0' || node.children[board[r][c] - 'a'] == null)
            return;
        var oldChar = board[r][c];
        var childNode = node.children[oldChar - 'a'];
        board[r][c] = '0';
        Bt(board, childNode, r + 1, c, path + oldChar, res);
        Bt(board, childNode, r - 1, c, path + oldChar, res);
        Bt(board, childNode, r, c + 1, path + oldChar, res);
        Bt(board, childNode, r, c - 1, path + oldChar, res);
        board[r][c] = oldChar;
    }
}
