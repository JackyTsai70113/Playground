namespace playground.LeetCode._0000_0999;

public class _0974_SubarraysDivByK
{
    public static int SubarraysDivByK(int[] nums, int k)
    {
        var memo = new int[k];
        memo[0] = 1;
        int res = 0;
        for (int i = 0, sum = 0; i < nums.Length; i++)
        {
            sum = (sum + nums[i] % k + k) % k;
            res += memo[sum];
            memo[sum]++;
        }
        return res;
    }
}
