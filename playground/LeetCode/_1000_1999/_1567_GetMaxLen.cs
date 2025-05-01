namespace playground;

public class _1567_GetMaxLen
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product
    /// </summary>
    public static int GetMaxLen(int[] nums)
    {
        int positive = 0, negative = 0, res = 0;
        foreach (var num in nums)
        {
            if (num > 0)
            {
                positive++;
                if (negative > 0) negative++;
            }
            else if (num < 0)
            {
                var newPositive = negative > 0 ? negative + 1 : 0;
                negative = positive + 1;
                positive = newPositive;
            }
            else
            {
                positive = negative = 0;
            }
            res = Math.Max(res, positive);
        }
        return res;
    }
}
