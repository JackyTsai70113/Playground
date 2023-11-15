namespace playground;

public class MaximumStrongPairXor_2932
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
