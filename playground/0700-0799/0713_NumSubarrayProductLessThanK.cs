using System;

namespace playground._0700_0799;

public class _0713_NumSubarrayProductLessThanK
{
    public static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        bool Valid(long val)
        {
            return val < k;
        }
        if (k == 0)
            return 0;
        int n = nums.Length;
        int l = 0, count = 0;
        long val = 1;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            val *= nums[r];
            while (l <= r && !Valid(val))
            {
                // update state by A[l]
                val /= nums[l];
                l++;
            }
            if (Valid(val))
                count += r - l + 1;
        }
        return count;
    }
}