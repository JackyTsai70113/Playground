namespace playground.Greedy;

public class MinSumClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-equal-sum-of-two-arrays-after-replacing-zeros
    /// </summary>
    public static long MinSum(int[] nums1, int[] nums2)
    {
        long sum1 = 0, sum2 = 0;
        int cnt1 = 0, cnt2 = 0;
        foreach (var n in nums1)
        {
            if (n == 0)
                cnt1++;
            sum1 += n;
        }
        foreach (var n in nums2)
        {
            if (n == 0)
                cnt2++;
            sum2 += n;
        }
        if (cnt1 == 0 && sum2 + cnt2 > sum1) return -1;
        if (cnt2 == 0 && sum1 + cnt1 > sum2) return -1;
        return Math.Max(sum1 + cnt1, sum2 + cnt2);
    }
}
