namespace playground.LeetCode._0000_0999;

public class _0211_WordDictionary
{
    // false: isFinish, children: a-z
    private readonly TrieNode<bool> root = new(false, new TrieNode<bool>[26]);
    public _0211_WordDictionary() { }

    public void AddWord(string word)
    {
        var cur = root;
        foreach (var c in word)
        {
            if (cur.children[c - 'a'] == null)
            {
                cur.children[c - 'a'] = new(false, new TrieNode<bool>[26]);
            }
            cur = cur.children[c - 'a'];
        }
        cur.val = true;
    }

    public bool Search(string word)
    {
        return Search(root, word, 0);
    }

    public bool Search(TrieNode<bool> node, string word, int start)
    {
        if (start == word.Length)
            return node.val;

        if (word[start] != '.')
        {
            if (node.children[word[start] - 'a'] == null)
                return false;
            else
                return Search(node.children[word[start] - 'a'], word, start + 1);
        }
        for (int i = 0; i < 26; i++)
        {
            if (node.children[i] != null && Search(node.children[i], word, start + 1))
                return true;
        }
        return false;
    }
}
