namespace playground;

public class FindNonMinOrMax_2733
{
    /// <summary>
    /// https://leetcode.com/problems/neither-minimum-nor-maximum
    /// </summary>
    public static int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length <= 2) return -1;
        int? a = null, b = null;
        foreach (var x in nums)
        {
            if (a == null || x > a)
                (a, b) = (x, a);
            else if (b == null || x > b)
                b = x;
        }
        return b.Value;
    }
}
