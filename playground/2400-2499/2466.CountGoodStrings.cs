namespace playground;

public class CountGoodStrings2466
{
    /// <summary>
    /// https://leetcode.com/problems/count-ways-to-build-good-strings
    /// </summary>
    public static int CountGoodStrings(int low, int high, int zero, int one)
    {
        int res = 0, MOD = (int)(1e9 + 7);
        var memo = new int[high + 1];
        memo[0] = 1;
        for (int i = 1; i <= high; i++)
        {
            if (i - zero >= 0) memo[i] = (memo[i] + memo[i - zero]) % MOD;
            if (i - one >= 0) memo[i] = (memo[i] + memo[i - one]) % MOD;
            if (i >= low) res = (res + memo[i]) % MOD;
        }
        return res;
    }
}
