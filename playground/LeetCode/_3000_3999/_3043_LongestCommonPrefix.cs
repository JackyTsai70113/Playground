namespace playground.LeetCode._3000_3999;

public class _3043_LongestCommonPrefix
{
    public static int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        Trie root = new();
        foreach (var num in arr1)
        {
            root.Insert(num);
        }
        int res = 0;
        foreach (var num in arr2)
        {
            res = Math.Max(res, root.Search(num));
        }
        return res;
    }

    public class Trie
    {
        public Trie[] children;
        public Trie()
        {
            children = new Trie[10];
        }

        public void Insert(int val)
        {
            var cur = this;
            string s = val.ToString();
            foreach (var c in s)
            {
                if (cur.children[c - '0'] == null)
                    cur.children[c - '0'] = new();
                cur = cur.children[c - '0'];
            }
        }

        public int Search(int val)
        {
            var cur = this;
            string s = val.ToString();
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (cur.children[s[i] - '0'] == null)
                    break;
                cur = cur.children[s[i] - '0'];
            }
            return i;
        }
    }
}
