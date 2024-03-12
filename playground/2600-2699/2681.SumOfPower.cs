namespace playground;

public class SumOfPower2681
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-heroes
    /// </summary>
    public static int SumOfPower(int[] nums)
    {
        int n = nums.Length, MOD = (int)(1e9 + 7);
        Array.Sort(nums);
        long res = 0, presum = 0;
        for (int i = 0; i < n; i++)
        {
            res = (res + (presum + nums[i]) * nums[i] % MOD * nums[i] % MOD) % MOD;
            presum = (presum * 2 + nums[i]) % MOD;
        }
        return (int)res;
    }
}
