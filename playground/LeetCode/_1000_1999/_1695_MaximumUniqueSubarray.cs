namespace playground.LeetCode._1000_1999;

public class _1695_MaximumUniqueSubarray
{
    public static int MaximumUniqueSubarray(int[] nums)
    {
        var set = new HashSet<int>();
        bool Valid(int num)
        {
            return !set.Contains(num);
        }
        int max = 0, sum = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            sum += nums[r];
            while (!Valid(nums[r]))
            {
                // update state by A[l]
                set.Remove(nums[l]);
                sum -= nums[l];
                l++;
            }
            set.Add(nums[r]);
            max = Math.Max(max, sum);
        }
        return max;
    }
}
