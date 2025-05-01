using Microsoft.VisualBasic;

namespace playground.LeetCode._0000_0999;

public class _0446_NumberOfArithmeticSlices
{
    /// <summary>
    /// https://leetcode.com/problems/arithmetic-slices-ii-subsequence
    /// </summary>
    public static int NumberOfArithmeticSlices(int[] nums)
    {
        int res = 0, n = nums.Length;
        var dp = new Dictionary<long, int>[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new();
            for (int j = 0; j < i; j++)
            {
                long diff = (long)nums[i] - nums[j];
                dp[j].TryGetValue(diff, out var cnt);
                dp[i][diff] = 1 + cnt + (dp[i].ContainsKey(diff) ?
                    dp[i][diff] : 0);
                res += cnt;
            }
        }
        return res;
    }
}
