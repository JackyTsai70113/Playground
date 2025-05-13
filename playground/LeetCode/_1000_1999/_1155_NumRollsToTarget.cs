namespace playground.LeetCode._1000_1999;

public class _1155_NumRollsToTarget
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-dice-rolls-with-target-sum
    /// </summary>
    public static int NumRollsToTarget(int n, int k, int target)
    {
        var dp = new int[target + 1];
        dp[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            var dp2 = new int[target + 1];
            for (var j = 1; j <= k; j++)
                for (var m = j; m <= target; m++)
                    dp2[m] = (dp2[m] + dp[m - j]) % 1_000_000_007;
            dp = dp2;
        }

        return dp[target];
    }
}