namespace playground;

/// <summary>
/// https://leetcode.com/problems/implement-trie-prefix-tree
/// </summary>
public class Trie0208
{
    // false: isFinish, children: a-z
    private readonly TrieNode<bool> root = new(false, new TrieNode<bool>[26]);

    public void Insert(string word)
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
        var cur = root;
        foreach (var c in word)
        {
            if (cur.children[c - 'a'] == null)
            {
                return false;
            }
            cur = cur.children[c - 'a'];
        }
        return cur.val;
    }

    public bool StartsWith(string prefix)
    {
        var cur = root;
        foreach (var c in prefix)
        {
            if (cur.children[c - 'a'] == null)
            {
                return false;
            }
            cur = cur.children[c - 'a'];
        }
        return true;
    }
}