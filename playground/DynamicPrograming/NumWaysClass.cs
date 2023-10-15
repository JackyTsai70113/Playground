using System.Globalization;
using playground.Mathematics;

namespace playground.DynamicPrograming;

public class NumWaysClass
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps
    /// </summary>
    public static int NumWays(int steps, int n)
    {
        int MOD = (int)1e9 + 7;
        n = Math.Min(steps, n);
        long[] memo = new long[n], memo2 = new long[n];
        memo[0] = 1;
        for (int i = 0; i < steps; ++i)
        {
            memo2 = new long[n];
            for (int j = 0; j < n; j++)
                memo2[j] = ((j > 0 ? memo[j - 1] : 0) + memo[j] + (j < n - 1 ? memo[j + 1] : 0)) % MOD;
            memo = memo2;
        }
        return (int)memo[0];
    }
}
