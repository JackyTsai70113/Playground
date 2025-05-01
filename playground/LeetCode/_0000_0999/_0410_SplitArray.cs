namespace playground.LeetCode._0000_0999;

public class _0410_SplitArray
{
    /// <summary>
    /// https://leetcode.com/problems/split-array-largest-sum
    /// </summary>
    public static int SplitArray(int[] nums, int k)
    {
        int l = 0, r = 0;
        foreach (var num in nums)
        {
            l = Math.Max(l, num);
            r += num;
        }

        bool RequiredSubArray(int m)
        {
            int count = 1, cur = 0;
            foreach (var num in nums)
            {
                if (cur + num <= m)
                {
                    cur += num;
                }
                else
                {
                    cur = num;
                    count++;
                }
            }
            return count <= k;
        }

        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (RequiredSubArray(m))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }
}
