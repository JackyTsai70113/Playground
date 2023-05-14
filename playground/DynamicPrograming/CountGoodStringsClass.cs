namespace playground.DynamicPrograming;

public class CountGoodStringsClass
{
    /// <remarks>https://leetcode.com/problems/count-ways-to-build-good-strings</remarks>
    public static int CountGoodStrings(int low, int high, int zero, int one)
    {
        int MOD = (int)(1e9 + 7);
        var dp = new long[high + 1];
        dp[0] = 1;
        for (int i = 0; i <= high; ++i)
        {
            if (i + zero <= high) dp[i + zero] = (dp[i + zero] + dp[i]) % MOD;
            if (i + one <= high) dp[i + one] = (dp[i + one] + dp[i]) % MOD;
        }
        long res = 0;
        for (int i = low; i <= high; ++i)
        {
            res = (res + dp[i]) % MOD;
        }
        return (int)res;
    }
}
