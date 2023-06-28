namespace playground.SlidingWindow;

public class MinOperationsClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero
    /// </summary>
    public static int MinOperations(int[] nums, int x)
    {
        int sum = nums.Sum();
        var res = AtMost(nums, sum - x);
        return res == -1 ? -1 : nums.Length - res;
    }

    static int AtMost(int[] nums, int x)
    {
        int res = -1;
        for (int i = 0, j = 0; i < nums.Length; ++i)
        {
            x -= nums[i];
            while (x < 0 && j < nums.Length)
            {
                x += nums[j++];
            }
            if (x == 0)
            {
                res = Math.Max(res, i - j + 1);
            }
        }
        return res;
    }
}
