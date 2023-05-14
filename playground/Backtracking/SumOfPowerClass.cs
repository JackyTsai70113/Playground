namespace playground.Backtracking;

public class SumOfPowerClass
{
    public static int SumOfPower(int[] nums)
    {
        int n = nums.Length, MOD = (int)(1e9 + 7);
        long res = 0;
        var twos = new long[n];
        twos[0] = 1;
        for (int i = 1; i < n; ++i)
        {
            twos[i] = twos[i - 1] * 2 % MOD;
        }
        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= 0; --i)
        {
            long temp = nums[i] % MOD;
            temp = temp * nums[i] % MOD;
            res = (res + temp * nums[i] % MOD) % MOD;

            for (int j = 0; j < i; ++j)
            {
                res = (res + temp * nums[j] % MOD * twos[i - j - 1] % MOD) % MOD;
            }
        }
        return (int)res;
    }
}
