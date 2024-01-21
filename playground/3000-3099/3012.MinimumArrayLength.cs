namespace playground;

public class MinimumArrayLength3012
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-length-of-array-using-operations
    /// </summary>
    public static int MinimumArrayLength(int[] nums)
    {
        int min = nums.Min();
        int count = nums.Where(x => x == min).Count();
        foreach (var num in nums)
        {
            if (num % min > 0)
                return 1;
        }
        return (count + 1) / 2;
    }
}
