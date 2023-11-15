namespace playground;

public class MaximumElementAfterDecrementingAndRearranging_1846
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-element-after-decreasing-and-rearranging
    /// </summary>
    public static int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        Array.Sort(arr);
        var res = 0;
        foreach (var num in arr)
            res = Math.Min(res + 1, num);
        return res;
    }
}
