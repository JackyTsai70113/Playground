using System;

namespace playground.LeetCode._3000_3999;

public class _3557_MaxSubstrings
{
    public static int MaxSubstrings(string word)
    {
        int n = word.Length;
        var dp = new int[n + 1];
        var indexes = new List<int>[26];
        for (int i = 0; i < 26; i++) indexes[i] = new();
        for (int i = 0; i < n; i++)
        {
            dp[i + 1] = dp[i];
            int cur = word[i] - 'a';
            if (indexes[cur].Count > 0)
            {
                int j = indexes[cur].Count - 1;
                while (j >= 0 && i - indexes[cur][j] + 1 < 4) j--;
                if (j >= 0)
                {
                    dp[i + 1] = Math.Max(dp[i + 1], dp[indexes[cur][j]] + 1);
                }
            }
            indexes[cur].Add(i);
        }
        return dp.Max();
    }
}
