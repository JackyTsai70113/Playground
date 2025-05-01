namespace playground.LeetCode._2000_2999;

public class _2930_StringCount
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-strings-which-can-be-rearranged-to-contain-substring
    /// </summary>
    public static int StringCount(int n)
    {
        int MOD = (int)(1e9 + 7);
        var memo = new long[n + 1, 2, 3, 2];
        memo[0, 0, 0, 0] = 1;

        void modAdd(ref long x, long y)
        {
            x = (x + y) % MOD;
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 2; l++)
                    {
                        modAdd(ref memo[i, j, k, l], 23 * memo[i - 1, j, k, l]);
                        modAdd(ref memo[i, Math.Min(1, j + 1), k, l], memo[i - 1, j, k, l]);
                        modAdd(ref memo[i, j, Math.Min(2, k + 1), l], memo[i - 1, j, k, l]);
                        modAdd(ref memo[i, j, k, Math.Min(1, l + 1)], memo[i - 1, j, k, l]);
                    }
                }
            }
        }
        return (int)memo[n, 1, 2, 1];
    }
}
