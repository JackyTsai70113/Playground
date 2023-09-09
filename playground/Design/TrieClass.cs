using playground.TreeNodes;

namespace playground.Design;

public interface ITrieClass
{
    void Insert(string word);
    bool Search(string word);
    bool StartsWith(string prefix);
}

/// <remarks>https://leetcode.com/problems/implement-trie-prefix-tree</remarks>
public class TrieClass : ITrieClass
{
    private readonly TreeNode<bool> root;
    public TrieClass()
    {
        root = new(); // for all alphabets
    }

    public void Insert(string word)
    {
        var cur = root;
        foreach (var c in word)
        {
            int childIndex = c - 'a';
            if (!cur.HasChild(childIndex))
                cur.AddChild(childIndex, false);
            cur = cur.GetChild(childIndex);
        }
        cur.SetValue(true);
    }

    public bool Search(string word)
    {
        var routes = word.Select(c => c - 'a');
        if (!root.TrySearch(routes, out bool isEnd))
        {
            return false;
        }
        return isEnd;
    }

    public bool StartsWith(string prefix)
    {
        var routes = prefix.Select(c => c - 'a');
        return root.TrySearch(routes, out _);
    }
}