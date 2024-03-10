namespace playground;

public class MaximumStrength3077
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-strength-of-k-disjoint-subarrays
    /// </summary>
    public static long MaximumStrength(int[] nums, int k)
    {
        int n = nums.Length;
        var memo = new long[n, k + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k + 1; j++)
            {
                memo[i, j] = long.MinValue;
            }
        }
        long dp(int i, int k)
        {
            if (k == 0)
                return 0;
            if (i > nums.Length - k)
                return long.MinValue;
            if (memo[i, k] != long.MinValue)
                return memo[i, k];
            var num = (long)k * (k % 2 > 0 ? nums[i] : -nums[i]);
            var a = dp(i + 1, k);
            if (a != long.MinValue)
                memo[i, k] = Math.Max(memo[i, k], num + a);
            var b = dp(i + 1, k - 1);
            if (b != long.MinValue)
                memo[i, k] = Math.Max(memo[i, k], num + b);
            var c = dp(i + 2, k - 1);
            if (c != long.MinValue)
                memo[i, k] = Math.Max(memo[i, k], num + c);
            return memo[i, k];
        }
        long res = long.MinValue;
        for (int i = 0; i <= n - k; i++)
            res = Math.Max(res, dp(i, k));
        return res;
    }
}
