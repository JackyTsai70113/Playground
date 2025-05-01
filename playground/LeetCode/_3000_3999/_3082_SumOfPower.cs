namespace playground;

public class _3082_SumOfPower
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-sum-of-the-power-of-all-subsequences
    /// </summary>
    public static int SumOfPower(int[] nums, int k)
    {
        var memo = new long[k + 1];
        memo[0] = 1;
        foreach (var num in nums)
        {
            for (int i = k; i >= 0; i--)
            {
                memo[i] = (memo[i] * 2 + (i >= num ? memo[i - num] : 0)) % (long)(1e9 + 7);
            }
        }
        return (int)memo[k];
    }
}
