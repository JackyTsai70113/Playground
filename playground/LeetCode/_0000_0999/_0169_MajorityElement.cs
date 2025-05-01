namespace playground.LeetCode._0000_0999;

public class _0169_MajorityElement
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element
    /// </summary>
    public static int MajorityElement(int[] nums)
    {
        return MajorityElement(nums, 0, nums.Length - 1);
    }

    static int MajorityElement(int[] nums, int l, int r)
    {
        if (l == r)
            return nums[l];
        // divide
        int m = l + (r - l) / 2;

        // conquer
        var leftX = MajorityElement(nums, l, m);
        var rightX = MajorityElement(nums, m + 1, r);

        // combine
        if (leftX == rightX)
            return leftX;
        int leftCount = 0, rightCount = 0;
        for (int i = l; i <= m; i++)
        {
            if (nums[i] == leftX)
                leftCount++;
        }
        for (int i = m + 1; i <= r; i++)
        {
            if (nums[i] == rightX)
                rightCount++;
        }
        return leftCount > rightCount ? leftX : rightX;
    }
}
