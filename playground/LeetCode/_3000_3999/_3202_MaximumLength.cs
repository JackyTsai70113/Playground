namespace playground;

public class _3202_MaximumLength
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-ii
    /// </summary>
    public static int MaximumLength(int[] nums, int k)
    {
        var dp = new int[k, k];
        var res = 0;
        foreach (var num in nums)
        {
            int mod = num % k;
            var dp2 = new int[k];
            for (int i = 0; i < k; i++)
                dp2[i] = dp[mod, i] + 1;
            for (int i = 0; i < k; i++)
            {
                dp[i, mod] = dp2[i];
                res = Math.Max(res, dp[i, mod]);
            }
        }
        return res;
    }
}
