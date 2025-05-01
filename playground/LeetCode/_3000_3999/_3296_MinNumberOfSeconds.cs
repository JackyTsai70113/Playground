namespace playground;

public class _3296_MinNumberOfSeconds
{
    public static long MinNumberOfSeconds(int h, int[] workerTimes)
    {
        long l = 1, r = long.MaxValue;
        while (l < r)
        {
            long m = l + (r - l) / 2;
            long totalH = SumH(workerTimes, m);
            if (totalH >= h)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l;
    }

    static long SumH(int[] workerTimes, long limitTime)
    {
        long height = 0;
        foreach (var w in workerTimes)
        {
            long l = 0, r = 100000;
            while (l < r)
            {
                long m = l + (r - l + 1) / 2;
                if (m * (m + 1) / 2 * w <= limitTime)
                    l = m;
                else
                    r = m - 1;
            }
            height += l;
        }
        return height;
    }
}
