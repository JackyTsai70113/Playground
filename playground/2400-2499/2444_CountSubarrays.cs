namespace playground;

public class _2444_CountSubarrays
{
    public static long CountSubarrays(int[] nums, int minK, int maxK)
    {
        int imin = -1, imax = -1;
        long res = 0;
        for (int l = -1, r = 0; r < nums.Length; r++)
        {
            if (nums[r] == minK) imin = r;
            if (nums[r] == maxK) imax = r;
            if (nums[r] < minK || nums[r] > maxK) l = r;
            if (l < Math.Min(imin, imax))
                res += Math.Min(imin, imax) - l;
        }
        return res;
    }
}
