namespace playground.LeetCode._0000_0999;

public class _0189_Rotate
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-array
    /// </summary>
    public static void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Array.Reverse(nums, 0, nums.Length);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}