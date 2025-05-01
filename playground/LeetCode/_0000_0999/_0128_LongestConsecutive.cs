namespace playground.LeetCode._0000_0999;

public class _0128_LongestConsecutive
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence
    /// </summary>
    public static int LongestConsecutive(int[] nums)
    {
        var s = new HashSet<int>(nums);
        var res = 0;
        foreach (var start in s)
        {
            if (!s.Contains(start - 1))
            {
                int count = 1;
                while (s.Contains(start + count))
                    count++;
                res = Math.Max(res, count);
            }
        }
        return res;
    }
}