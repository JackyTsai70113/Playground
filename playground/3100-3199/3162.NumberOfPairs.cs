namespace playground;

public class NumberOfPairs3162
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-number-of-good-pairs-i
    /// </summary>
    public static int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        int res = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] % (nums2[j] * k) == 0) res++;
            }
        }
        return res;
    }
}
