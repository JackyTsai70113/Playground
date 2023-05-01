namespace playground.Interval;

public class InsertClass
{
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = intervals.ToList();

        int index = Interval.GetUpperBound(intervals.Select(x => x[0]).ToArray(), newInterval[0]);
        if (index < intervals.Length && intervals[index][1] < newInterval[0])
        {
            index++;
        }
        
        res.Insert(index, newInterval);

        while (index + 1 < res.Count && Interval.DoOverlap(res[index], res[index + 1]))
        {
            res[index] = Interval.MergedIntervals(res[index], res[index + 1]);
            res.RemoveAt(index + 1);
        }
        return res.ToArray();
    }
}
