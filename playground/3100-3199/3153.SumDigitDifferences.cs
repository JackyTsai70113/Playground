namespace playground;

public class SumDigitDifferences3153
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-digit-differences-of-all-pairs
    /// </summary>
    public static long SumDigitDifferences(int[] nums)
    {
        var l = new List<int[]>();
        for (int i = 0, a = nums[0]; a > 0; i++)
        {
            l.Add(new int[10]);
            l[i][a % 10]++;
            a /= 10;
        }
        long res = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0, a = nums[i]; a > 0; j++)
            {
                res += i - l[j][a % 10];
                l[j][a % 10]++;
                a /= 10;
            }
        }
        return res;
    }
}
