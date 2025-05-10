namespace playground.LeetCode._2000_2999;

public class _2918_MinSum
{
    public static long MinSum(int[] nums1, int[] nums2)
    {
        long sum1 = 0, sum2 = 0;
        bool zero1 = false, zero2 = false;
        foreach (var num in nums1)
        {
            if (num == 0) zero1 = true;
            sum1 += Math.Max(num, 1);
        }
        foreach (var num in nums2)
        {
            if (num == 0) zero2 = true;
            sum2 += Math.Max(num, 1);
        }
        if (sum1 > sum2 && !zero2)
            return -1;
        if (sum1 < sum2 && !zero1)
            return -1;
        return Math.Max(sum1, sum2);
    }
}
