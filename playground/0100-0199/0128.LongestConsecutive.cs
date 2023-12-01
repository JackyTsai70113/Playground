namespace playground;

public class LongestConsecutive_128
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