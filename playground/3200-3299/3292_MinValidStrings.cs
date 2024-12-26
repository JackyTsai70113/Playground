namespace playground._3200_3299;

public class _3292_MinValidStrings
{
    public static int MinValidStrings(string[] words, string target)
    {
        var root = new TrieNode();
        root.Insert(words);

        var dp = new int[target.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        for (int i = 0; i < target.Length; i++)
        {
            if (dp[i] == int.MaxValue)
                break;
            root.Search(target, i, dp);
        }
        return dp[target.Length] == int.MaxValue ? -1 : dp[target.Length];
    }

    public class TrieNode
    {
        public bool val = default;
        public readonly TrieNode[] children;
        public TrieNode()
        {
            val = false;
            children = new TrieNode[26];
        }

        public void Insert(IList<string> words)
        {
            TrieNode node;
            for (int i = 0; i < words.Count; i++)
            {
                node = this;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (node.children[words[i][j] - 'a'] == null)
                    {
                        node.children[words[i][j] - 'a'] = new TrieNode();
                    }
                    node = node.children[words[i][j] - 'a'];
                }
                node.val = true;
            }
        }

        public void Search(string str, int start, int[] dp)
        {
            TrieNode node = this;
            for (int i = start; i < str.Length; i++)
            {
                if (node.children[str[i] - 'a'] == null)
                {
                    break;
                }
                dp[i + 1] = Math.Min(dp[i + 1], dp[start] + 1);
                node = node.children[str[i] - 'a'];
            }
        }
    }
}
