namespace playground.LeetCode._3000_3999;

public class _3583_SpecialTriplets
{
    public static int SpecialTriplets(int[] nums)
    {
        Dictionary<int, long> d_left = new(), d_right = new();
        for (int i = 1; i < nums.Length; i++)
            d_right[nums[i]] = d_right.GetValueOrDefault(nums[i]) + 1;

        d_left.Add(nums[0], 1);

        long res = 0, MOD = 1_000_000_007;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (d_right.ContainsKey(nums[i]))
            {
                d_right[nums[i]]--;
                if (d_right[nums[i]] == 0)
                {
                    d_right.Remove(nums[i]);
                }
            }

            if (d_left.ContainsKey(nums[i] * 2) && d_right.ContainsKey(nums[i] * 2))
            {
                res = (res + d_left[nums[i] * 2] * d_right[nums[i] * 2] % MOD) % MOD;
            }

            d_left[nums[i]] = d_left.GetValueOrDefault(nums[i]) + 1;
        }
        return (int)res;
    }
}
