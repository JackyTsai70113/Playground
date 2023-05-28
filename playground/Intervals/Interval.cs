namespace playground.Intervals;

public class Interval
{
    public static bool DoOverlap(int[] i1, int[] i2)
    {
        return Math.Min(i1[1], i2[1]) - Math.Max(i1[0], i2[0]) >= 0;
    }

    public static int[] MergedIntervals(int[] i1, int[] i2)
    {
        return new int[] { Math.Min(i1[0], i2[0]), Math.Max(i1[1], i2[1]) };
    }
}
