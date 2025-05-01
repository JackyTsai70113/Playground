namespace playground;

public class _3213_MinimumCost
{
    public int MinimumCost(string target, string[] words, int[] costs)
    {
        int n = target.Length;
        Trie root = new();

        // add words
        for (int i = 0; i < words.Length; i++)
        {
            var cur = root;
            foreach (var c in words[i])
            {
                if (cur.children[c - 'a'] == null)
                    cur.children[c - 'a'] = new();
                cur = cur.children[c - 'a'];
            }
            if (cur.cost > costs[i]) cur.cost = costs[i];
        }

        var dp = new int[n + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        for (int i = 1; i < dp.Length; i++)
        {
            if (dp[i - 1] == int.MaxValue) continue;
            var cur = root;
            for (int j = i - 1; j < n; j++)
            {
                if (cur.children[target[j] - 'a'] == null)
                    break;
                cur = cur.children[target[j] - 'a'];
                if (cur.cost < int.MaxValue)
                {
                    dp[j + 1] = Math.Min(dp[j + 1], dp[i - 1] + cur.cost);
                }
            }
        }
        return dp[^1] == int.MaxValue ? -1 : dp[^1];
    }

    public class Trie
    {
        public int cost = int.MaxValue;
        public Trie[] children;

        public Trie()
        {
            children = new Trie[26];
        }
    }
}
