namespace playground;

public class MinimizeMax2616
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs
    /// </summary>
    public static int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);
        int l = 0, r = nums[^1] - nums[0];
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (CountBiggerThanP(nums, p, m))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    static bool CountBiggerThanP(int[] nums, int p, int diff)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (Math.Abs(nums[i] - nums[i - 1]) <= diff)
            {
                count++;
                i++;
            }
        }
        return count >= p;
    }
}