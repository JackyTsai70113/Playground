namespace playground.Design;

/// <remarks>https://leetcode.com/problems/implement-trie-prefix-tree</remarks>>
public class TrieClass
{
    private static readonly int MAX = 26;
    private class TreeNode
    {
        public TreeNode(TreeNode[] children)
        {
            this.children = children;
        }

        private bool isEnd;
        private readonly TreeNode[] children;

        public void Add(char ch)
        {
            children[ch - 'a'] = new TreeNode(new TreeNode[MAX]);
        }

        public TreeNode Get(char ch)
        {
            return children[ch - 'a'];
        }

        public bool Contains(char ch)
        {
            return children[ch - 'a'] != null;
        }

        public bool IsEnd()
        {
            return isEnd;
        }

        public void SetEnd(bool isEnd)
        {
            this.isEnd = isEnd;
        }
    }

    readonly TreeNode root;
    public TrieClass()
    {
        root = new TreeNode(new TreeNode[MAX]);
    }

    public void Insert(string word)
    {
        var cur = root;
        for (int i = 0; i < word.Length; ++i)
        {
            if (!cur.Contains(word[i])) cur.Add(word[i]);
            cur = cur.Get(word[i]);
        }
        cur.SetEnd(true);
    }

    public bool Search(string word)
    {
        var cur = root;
        for (int i = 0; i < word.Length && cur != null; ++i)
        {
            if (!cur.Contains(word[i])) return false;
            cur = cur.Get(word[i]);
        }
        return cur != null && cur.IsEnd();
    }

    public bool StartsWith(string prefix)
    {
        var cur = root;
        for (int i = 0; i < prefix.Length && cur != null; ++i)
        {
            if (!cur.Contains(prefix[i])) return false;
            cur = cur.Get(prefix[i]);
        }
        return cur != null;
    }
}
