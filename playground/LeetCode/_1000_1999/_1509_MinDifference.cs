namespace playground;

public class _1509_MinDifference
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves
    /// </summary>
    public static int MinDifference(int[] nums)
    {
        if (nums.Length <= 4) return 0;
        var res = int.MaxValue;
        Array.Sort(nums);
        for (int i = 0; i < 4; i++)
        {
            res = Math.Min(res, nums[i + nums.Length - 4] - nums[i]);
        }
        return res;
    }
}
