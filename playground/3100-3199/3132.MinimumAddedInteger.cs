namespace playground;

public class MinimumAddedInteger3132
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-integer-added-to-array-ii
    /// </summary>
    public static int MinimumAddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int res = int.MaxValue, n = nums1.Length;
        bool check(int x)
        {
            int count = 0;
            for (int i = 0, j = 0; i < n && j < n - 2; i++)
            {
                if (nums1[i] + x != nums2[j]) count++;
                else j++;
            }
            return count <= 2;
        }
        for (int i = 0; i <= 2; i++)
        {
            var x = nums2[0] - nums1[i];
            if (check(x)) res = Math.Min(res, x);
        }
        return res;
    }
}
