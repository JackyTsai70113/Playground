namespace playground.LeetCode._0000_0999;

public class _0209_MinSubArrayLen
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        bool Valid(int sum)
        {
            return sum >= target;
        }
        int n = nums.Length;
        int l = 0, sum = 0, min = int.MaxValue;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            sum += nums[r];
            while (l <= r && Valid(sum))
            {
                min = Math.Min(min, r - l + 1);
                // update state by A[l]
                sum -= nums[l];
                l++;
            }
        }
        return min == int.MaxValue ? 0 : min;
    }
}
