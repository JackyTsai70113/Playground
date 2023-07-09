namespace playground.SlidingWindow;

public class AlternatingSubarrayClass
{
    /// <summary>
    /// https://leetcode.com/problems/longest-alternating-subarray/
    /// </summary>
    public static int AlternatingSubarray(int[] nums)
    {
        var res = 0;
        for (int i = 1; i < nums.Length; ++i)
        {
            int a = 1;
            for (int j = i; j < nums.Length; ++j)
            {
                if (nums[j] - nums[j - 1] == a)
                {
                    a *= -1;
                    res = Math.Max(res, j - i + 2);
                }
                else
                {
                    break;
                }
            }
        }
        return res;
    }
}
