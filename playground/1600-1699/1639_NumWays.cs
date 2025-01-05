namespace playground._1600_1699;

public class _1639_NumWays
{
    public static int NumWays(string[] words, string target)
    {
        int m = words.Length, n = words[0].Length;
        var chs = new int[n][];
        for (int i = 0; i < n; i++)
        {
            chs[i] = new int[26];
            for (int j = 0; j < m; j++)
            {
                chs[i][words[j][i] - 'a']++;
            }
        }

        long MOD = (long)1e9 + 7;
        var memo = new long[n, target.Length];

        for (int j = 0; j < target.Length; j++)
        {
            if (j == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    memo[i, 0] = chs[i][target[0] - 'a'];
                    if (i > 0)
                    {
                        memo[i, j] = (memo[i, j] + memo[i - 1, j]) % MOD;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        memo[i, j] = 0;
                    }
                    else
                    {
                        memo[i, j] = (memo[i - 1, j - 1] * chs[i][target[j] - 'a']) % MOD;
                        memo[i, j] = (memo[i, j] + memo[i - 1, j]) % MOD;
                    }
                }
            }
        }
        return (int)memo[n - 1, target.Length - 1];
    }
}
