namespace playground.LeetCode._2000_2999;

public class _2932_MaximumStrongPairXor
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-strong-pair-xor-i
    /// </summary>
    public static int MaximumStrongPairXor(int[] nums)
    {
        var res = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (Math.Min(nums[i], nums[j]) >= Math.Abs(nums[i] - nums[j]))
                {
                    res = Math.Max(res, nums[i] ^ nums[j]);
                }
            }
        }
        return res;
    }
}
