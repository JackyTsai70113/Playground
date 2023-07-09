namespace playground.DynamicPrograming;

public class MaxNonDecreasingLengthClass
{
    /// <summary>
    /// https://leetcode.com/problems/longest-non-decreasing-subarray-from-two-arrays
    /// </summary>
    public static int MaxNonDecreasingLength(int[] nums1, int[] nums2)
    {
        var res = 0;
        int n = nums1.Length;
        var memo1 = new int[n];
        var memo2 = new int[n];
        void dp(int idx)
        {
            if (idx == n - 1)
            {
                memo1[idx] = 1;
                memo2[idx] = 1;
                res = Math.Max(res, Math.Max(memo1[idx], memo2[idx]));
                return;
            }
            if (memo1[idx] == 0)
            {
                memo1[idx] = 1;
                memo2[idx] = 1;
                dp(idx + 1);
                if (nums1[idx] <= nums1[idx + 1])
                    memo1[idx] = Math.Max(memo1[idx], 1 + memo1[idx + 1]);
                if (nums1[idx] <= nums2[idx + 1])
                    memo1[idx] = Math.Max(memo1[idx], 1 + memo2[idx + 1]);
                if (nums2[idx] <= nums1[idx + 1])
                    memo2[idx] = Math.Max(memo2[idx], 1 + memo1[idx + 1]);
                if (nums2[idx] <= nums2[idx + 1])
                    memo2[idx] = Math.Max(memo2[idx], 1 + memo2[idx + 1]);
            }
            res = Math.Max(res, Math.Max(memo1[idx], memo2[idx]));
        }
        dp(0);
        return res;
    }
}
