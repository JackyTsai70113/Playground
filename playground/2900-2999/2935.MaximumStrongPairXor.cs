namespace playground;

public class MaximumStrongPairXor_2935
{
    public static int MaximumStrongPairXor(int[] nums)
    {
        var res = 0;
        var trie = new Trie(20);
        foreach (var num in nums)
            trie.Insert(num);
        foreach (var num in nums)
            res = Math.Max(res, num ^ trie.SearchXorMax(num, num * 2));
        return res;
    }

    class Trie
    {
        readonly TreeNode _root = new();
        readonly int _level;
        public Trie(int level)
        {
            _level = level;
        }
        public void Insert(int num)
        {
            var cur = _root;
            for (int i = _level - 1; i >= 0; --i)
            {
                int idx = (num >> i) & 1;
                if (cur.children[idx] == null)
                    cur.children[idx] = new();
                cur = cur.children[idx];
                cur.min = Math.Min(cur.min, num);
                cur.max = Math.Max(cur.max, num);
            }
        }

        public int SearchXorMax(int num, int max)
        {
            var res = 0;
            var cur = _root;
            for (int i = _level - 1; i >= 0; --i)
            {
                int a = (num >> i) & 1, b = 1 - a;
                if (cur.children[b] != null && cur.children[b].min <= max && cur.children[b].max > num)
                {
                    res |= b << i;
                    cur = cur.children[b];
                }
                else
                {
                    res |= a << i;
                    cur = cur.children[a];
                }
            }
            return res;
        }
    }

    class TreeNode
    {
        public TreeNode[] children = new TreeNode[2];
        public int min = int.MaxValue;
        public int max = int.MinValue;
    }
}
