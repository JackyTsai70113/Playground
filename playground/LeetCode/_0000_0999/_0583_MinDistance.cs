namespace playground.LeetCode._0000_0999;

public class _0583_MinDistance
{
    public static int MinDistance(string word1, string word2)
    {
        if (word1.Length < word2.Length)
            return MinDistance(word2, word1);
        int n1 = word1.Length, n2 = word2.Length;
        var dp = new int[n2 + 1];
        var dp2 = new int[n2 + 1];
        for (int i = 0; i <= n2; i++)
            dp[i] = i;
        for (int i = 0; i < n1; i++)
        {
            dp2[0] = i + 1;
            for (int j = 0; j < n2; j++)
            {
                if (word1[i] != word2[j])
                    dp2[j + 1] = 1 + Math.Min(dp2[j], dp[j + 1]);
                else
                    dp2[j + 1] = dp[j];
            }
            (dp, dp2) = (dp2, dp);
        }
        return dp[n2];
    }
}
