namespace playground;

public class _1498_NumSubseq
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition
    /// </summary>
    public static int NumSubseq(int[] nums, int target)
    {
        long res = 0, MOD = (long)1e9 + 7;
        Array.Sort(nums);
        var pow = new long[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            pow[i] = i == 0 ? 1 : (pow[i - 1] * 2) % MOD;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int l = i, r = nums.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] >= target - nums[i] + 1)
                    r = m;
                else
                    l = m + 1;
            }

            if (l > i)
            {
                res = (res + pow[l - i - 1]) % MOD;
            }
        }
        return (int)res;
    }
}
