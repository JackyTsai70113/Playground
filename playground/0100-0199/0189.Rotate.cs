namespace playground;

public class Rotate0189
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