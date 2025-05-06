namespace playground.LeetCode._1000_1999;

public class _1493_LongestSubarray
{
    /// <summary>
    /// O(N)/O(1)
    /// </summary>
    public static int LongestSubarray(int[] nums)
    {
        static bool Valid(int zeroCount)
        {
            return zeroCount <= 1;
        }
        int n = nums.Length;
        int l = 0, max = -1, zeroCount = 0;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            if (nums[r] == 0)
                zeroCount++;
            while (!Valid(zeroCount))
            {
                // update state by A[l]
                if (nums[l] == 0)
                    zeroCount--;
                l++;
            }
            max = Math.Max(max, r - l);
        }
        return max;
    }
}
