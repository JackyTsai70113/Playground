namespace playground.LeetCode._2000_2999;

public class _2905_FindIndices
{
    /// <summary>
    /// https://leetcode.com/problems/find-indices-with-index-and-value-difference-ii
    /// </summary>
    public static int[] FindIndices(int[] nums, int d, int v)
    {
        int mini = 0, maxi = 0, n = nums.Length;
        for (int i = d; i < n; ++i)
        {
            if (nums[i - d] < nums[mini]) mini = i - d;
            if (nums[i - d] > nums[maxi]) maxi = i - d;
            if (nums[i] - nums[mini] >= v) return new int[] { mini, i };
            if (nums[maxi] - nums[i] >= v) return new int[] { maxi, i };
        }
        return new int[] { -1, -1 };
    }
}
