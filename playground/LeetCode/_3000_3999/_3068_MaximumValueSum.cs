namespace playground;

public class _3068_MaximumValueSum
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-sum-of-node-values
    /// </summary>
    public static long MaximumValueSum(int[] nums, int k, int[][] _)
    {
        long res = 0;
        int minPos = int.MaxValue, maxNeg = int.MinValue, count = 0;
        foreach (var num in nums)
        {
            res += num;
            int val = (num ^ k) - num;
            if (val > 0)
            {
                minPos = Math.Min(minPos, val);
                res += val;
                count++;
            }
            else
            {
                maxNeg = Math.Max(maxNeg, val);
            }
        }

        return res + (count % 2 == 0 ? 0 : Math.Max(maxNeg, -minPos));
    }
}
