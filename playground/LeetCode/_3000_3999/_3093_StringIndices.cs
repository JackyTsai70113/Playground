namespace playground;

public class _3093_StringIndices
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-suffix-queries
    /// </summary>
    public static int[] StringIndices(string[] wordsContainer, string[] wordsQuery)
    {
        var arr = wordsContainer.Select((s, i) => (s, i))
            .OrderBy(x => x.s.Length)
            .ThenBy(x => x.i)
            .ToArray();
        var root = new Trie(arr[0].i);
        // add words to trie
        for (int i = 0; i < arr.Length; i++)
        {
            var word = arr[i].s;
            var cur = root;
            for (int j = word.Length - 1; j >= 0; j--)
            {
                if (cur.children[word[j] - 'a'] == null)
                {
                    cur.children[word[j] - 'a'] = new Trie(arr[i].i);
                }
                cur = cur.children[word[j] - 'a'];
            }
        }

        var res = new int[wordsQuery.Length];
        // find word in wordsQuery
        for (int i = 0; i < wordsQuery.Length; i++)
        {
            var word = wordsQuery[i];
            var cur = root;
            for (int j = word.Length - 1; j >= 0 && cur.children[word[j] - 'a'] != null; j--)
            {
                cur = cur.children[word[j] - 'a'];
            }
            res[i] = cur.index;
        }
        return res;
    }

    private class Trie
    {
        public int index;
        public Trie[] children;
        public Trie(int index)
        {
            this.index = index;
            children = new Trie[26];
        }
    }
}
