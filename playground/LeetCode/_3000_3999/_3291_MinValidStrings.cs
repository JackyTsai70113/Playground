namespace playground;

public class _3291_MinValidStrings
{
    public static int MinValidStrings(string[] words, string target)
    {
        var root = new TrieNode<bool>();
        for (int i = 0; i < words.Length; i++)
            Insert(root, words, i);

        var dp = new int[target.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        for (int i = 0; i < target.Length; i++)
        {
            if (dp[i] == int.MaxValue)
                continue;
            var validLengths = Search(root, target, i);
            foreach (var len in validLengths)
            {
                dp[i + len] = Math.Min(dp[i + len], dp[i] + 1);
            }
        }
        return dp[target.Length] == int.MaxValue ? -1 : dp[target.Length];
    }

    static List<int> Search(TrieNode<bool> node, string target, int start)
    {
        List<int> validLengths = new();
        int i = start;
        for (; i < target.Length; i++)
        {
            if (node.children[target[i] - 'a'] == null)
                break;
            node = node.children[target[i] - 'a'];
            validLengths.Add(i - start + 1);
        }
        return validLengths;
    }

    private static void Insert(TrieNode<bool> node, string[] words, int j)
    {
        for (int i = 0; i < words[j].Length; i++)
        {
            if (node.children[words[j][i] - 'a'] == null)
            {
                node.children[words[j][i] - 'a'] = new TrieNode<bool>();
            }
            node = node.children[words[j][i] - 'a'];
        }
    }
    public class TrieNode<T>
    {
        public readonly TrieNode<T>[] children;

        public TrieNode()
        {
            children = new TrieNode<T>[26];
        }
    }
}
