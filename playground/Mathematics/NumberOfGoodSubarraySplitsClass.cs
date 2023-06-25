namespace playground.Mathematics;

public class NumberOfGoodSubarraySplitsClass
{
    public static int NumberOfGoodSubarraySplits(int[] nums)
    {
        if (nums.Max() == 0)
            return 0;
        long res = 1, MOD = (long)(1e9 + 7);
        for (int i = 0, l = -1; i < nums.Length; ++i)
        {
            if (nums[i] == 1)
            {
                if (l != -1)
                {
                    res = res * (i - l) % MOD;
                }
                l = i;
            }
        }
        return (int)res;
    }
}
