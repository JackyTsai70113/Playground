namespace playground;

public class LargestPerimeter2971
{
    // https://leetcode.com/problems/find-polygon-with-the-largest-perimeter
    public static long LargestPerimeter(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        var presum = new long[n];
        for (int i = 0; i < n; ++i)
        {
            presum[i] = i == 0 ? nums[0] : presum[i - 1] + nums[i];
        }
        long res = -1;
        for (int i = n - 1; i >= 2; i--)
        {
            if (presum[i - 1] > nums[i])
            {
                res = presum[i - 1] + nums[i];
                break;
            }
        }
        return res;
    }
}
