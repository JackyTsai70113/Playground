namespace playground.LeetCode._2000_2999;

public class _2733_FindNonMinOrMax
{
    /// <summary>
    /// https://leetcode.com/problems/neither-minimum-nor-maximum
    /// </summary>
    public static int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length <= 2) return -1;
        int? a = nums[0], b = null;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > a)
                (a, b) = (nums[i], a);
            else if (b == null || nums[i] > b)
                b = nums[i];
        }
        return b.Value;
    }
}
