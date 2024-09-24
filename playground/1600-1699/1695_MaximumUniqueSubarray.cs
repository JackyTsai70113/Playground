namespace playground._1600_1699;

public class _1695_MaximumUniqueSubarray
{
    public static int MaximumUniqueSubarray(int[] nums)
    {
        var set = new HashSet<int>();
        bool Valid(int num)
        {
            return !set.Contains(num);
        }
        int l = 0, max = 0;
        int n = nums.Length;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            while (!Valid(nums[r]))
            {
                // update state by A[l]
                set.Remove(nums[l]);
                l++;
            }
            set.Add(nums[r]);
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
