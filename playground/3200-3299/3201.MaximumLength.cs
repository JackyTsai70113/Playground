namespace playground;

public class MaximumLength3201
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-i
    /// </summary>
    public static int MaximumLength(int[] nums)
    {
        int[] count = new int[2], end = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            count[nums[i] % 2]++;
            end[nums[i] % 2] = Math.Max(end[nums[i] % 2], end[1 - nums[i] % 2] + 1);
        }
        return Math.Max(Math.Max(count[0], count[1]), Math.Max(end[0], end[1]));
    }
}
