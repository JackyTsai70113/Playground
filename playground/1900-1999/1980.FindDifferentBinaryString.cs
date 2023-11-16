namespace playground;

public class FindDifferentBinaryString_1980
{
    public static string FindDifferentBinaryString(string[] nums)
    {
        var trie = new Trie(nums[0].Length);
        foreach (var num in nums)
            trie.Insert(num);
        return trie.SearchEmpty();
    }

    private class Trie
    {
        private readonly TreeNode _root = new(' ');
        private readonly int _level;
        public Trie(int level)
        {
            _level = level;
        }
        public void Insert(string s)
        {
            var cur = _root;
            for (int i = _level - 1; i >= 0; --i)
            {
                if (s[_level - 1 - i] == '0')
                {
                    cur.left ??= new('0');
                    cur = cur.left;
                }
                else
                {
                    cur.right ??= new('1');
                    cur = cur.right;
                }
            }
        }

        public string SearchEmpty()
        {
            var cur = _root;
            var res = new List<char>();
            var q = new Queue<(TreeNode, List<char>)>();
            q.Enqueue((cur, new List<char>()));
            while (q.Count > 0)
            {
                var (node, chs) = q.Dequeue();
                if (node.left == null)
                {
                    chs.Add('0');
                    res = chs;
                    break;
                }
                if (node.right == null)
                {
                    chs.Add('1');
                    res = chs;
                    break;
                }
                chs.Add('0');
                q.Enqueue((node.left, chs));
                var chs2 = new List<char>(chs);
                chs2[^1] = '1';
                q.Enqueue((node.right, chs2));
            }
            while (res.Count < _level)
            {
                res.Add('0');
            }
            return new string(res.ToArray());
        }
    }

    public class TreeNode
    {
        public char val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(char val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

