namespace playground._1600_1699;

public class _1658_MinOperations
{
    public static int MinOperations(int[] nums, int k)
    {
        int l = 0, max = -1;
        int n = nums.Length, sum = 0;
        foreach (var num in nums)
            sum += num;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            sum -= nums[r];
            while (l <= r && sum < k)
            {
                // update state by A[l]
                sum += nums[l];
                l++;
            }
            if (sum == k)
                max = Math.Max(max, r - l + 1);
        }
        return max == -1 ? -1 : n - max;
    }
}
