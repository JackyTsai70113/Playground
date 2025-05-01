namespace playground.UnitTest;

public class _1863_SubsetXORSum
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-all-subset-xor-totals
    /// </summary>
    public static int SubsetXORSum(int[] nums)
    {
        int n = nums.Length, res = 0;
        for (int bit = 1; bit < (1 << n); bit++)
        {
            int xor = 0;
            for (int j = 0; j < n; j++)
            {
                if ((bit & (1 << j)) > 0)
                    xor ^= nums[j];
            }
            res += xor;
        }
        return res;
    }
}
