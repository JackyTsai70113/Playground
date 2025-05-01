namespace playground.LeetCode._0000_0999;

public class _0283_MoveZeroes
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes
    /// </summary>
    public static void MoveZeroes(int[] nums)
    {
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (nums[r] == 0) continue;
            (nums[l], nums[r]) = (nums[r], nums[l++]);
        }
    }
}
