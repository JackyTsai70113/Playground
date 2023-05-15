namespace playground.Intervals;

public class Interval
{
    public static int GetUpperBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (arr[m] <= target)
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }
        return l;
    }

    public static bool DoOverlap(int[] i1, int[] i2)
    {
        return Math.Min(i1[1], i2[1]) - Math.Max(i1[0], i2[0]) >= 0;
    }

    public static int[] MergedIntervals(int[] i1, int[] i2)
    {
        return new int[] { Math.Min(i1[0], i2[0]), Math.Max(i1[1], i2[1]) };
    }
}
