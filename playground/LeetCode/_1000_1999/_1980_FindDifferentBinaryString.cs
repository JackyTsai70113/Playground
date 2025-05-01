namespace playground;

public class _1980_FindDifferentBinaryString
{
    /// <summary>
    /// https://leetcode.com/problems/find-unique-binary-string
    /// </summary>
    public static string FindDifferentBinaryString(string[] nums)
    {
        var trie = new Trie(nums[0].Length);
        foreach (var num in nums)
            trie.Insert(num);
        return trie.SearchEmpty();
    }

    class Trie
    {
        readonly TreeNode _root = new();
        readonly int _level;
        public Trie(int level)
        {
            _level = level;
        }
        public void Insert(string s)
        {
            var cur = _root;
            for (int i = _level - 1; i >= 0; --i)
            {
                int idx = s[_level - 1 - i] - '0';
                if (cur.children[idx] == null)
                    cur.children[idx] = new();
                cur = cur.children[idx];
            }
        }

        public string SearchEmpty()
        {
            var res = new List<char>();
            var cur = _root;
            for (int i = _level - 1; i >= 0; --i)
            {
                if (cur.children[0] == null)
                {
                    res.Add('0');
                }
                else if (cur.children[1] == null)
                {
                    res.Add('1');
                }
                else
                {
                    res.Add('0');
                    cur = cur.children[0];
                }
            }
            return new string(res.ToArray());
        }
    }

    class TreeNode
    {
        public TreeNode[] children = new TreeNode[2];
    }
}

