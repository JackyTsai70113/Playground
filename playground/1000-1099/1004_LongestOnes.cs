using System;

namespace playground._1000_1099;

public class _1004_LongestOnes
{
    public static int LongestOnes(int[] nums, int k)
    {
        bool Valid(int count)
        {
            return count <= k;
        }
        int l = 0, max = 0;
        int n = nums.Length, count = 0;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            if (nums[r] == 0)
                count++;
            while (!Valid(count))
            {
                // update state by A[l]
                if (nums[l] == 0)
                    count--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
