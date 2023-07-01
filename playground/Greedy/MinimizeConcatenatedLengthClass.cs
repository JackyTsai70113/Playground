namespace playground.Greedy;

public class MinimizeConcatenatedLengthClass
{
    public static int MinimizeConcatenatedLength(string[] words)
    {
        var memo = new int[1001, 26, 26];
        int helper(int cur, int l, int r)
        {
            if (cur == words.Length)
                return 0;
            if (memo[cur, l, r] != 0)
                return memo[cur, l, r];
            int left = helper(cur + 1, words[cur][0] - 'a', r) +
                (words[cur][^1] - 'a' == l ? -1 : 0);
            int right = helper(cur + 1, l, words[cur][^1] - 'a') +
                (r == words[cur][0] - 'a' ? -1 : 0);
            return memo[cur, l, r] = words[cur].Length + Math.Min(left, right);
        }
        return words[0].Length + helper(1, words[0][0] - 'a', words[0][^1] - 'a');
    }
}
