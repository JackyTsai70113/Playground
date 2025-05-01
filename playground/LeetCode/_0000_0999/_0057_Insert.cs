namespace playground.LeetCode._0000_0999;

public class _0057_Insert
{
    /// <summary>
    /// https://leetcode.com/problems/insert-interval
    /// </summary> 
    /// <remarks>
    /// O(N)/O(1)
    /// </remarks>
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = new List<int[]>();
        int n = intervals.Length, i = 0;
        while (i < n && intervals[i][1] < newInterval[0])
        {
            res.Add(intervals[i++]);
        }
        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        res.Add(newInterval);
        while (i < n)
        {
            res.Add(intervals[i++]);
        }
        return res.ToArray();
    }
}
