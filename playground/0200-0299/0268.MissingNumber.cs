namespace playground;

public class MissingNumber0268
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number
    /// </summary>
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }
}
