namespace playground.Arrays;

public class LongestAlternatingSubarrayClass
{
    /// <summary>
    /// https://leetcode.com/problems/longest-even-odd-subarray-with-threshold
    /// </summary>
    public static int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int a = 0;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] % 2 != a || nums[j] > threshold)
                    break;
                res = Math.Max(res, j - i + 1);
                a ^= 1;
            }
        }
        return res;
    }
}
