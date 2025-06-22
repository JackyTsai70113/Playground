namespace playground.LeetCode._3000_3999;

public class _3588_MaxArea
{
    public static long MaxArea(int[][] A)
    {
        int n = A.Length;
        if (n < 3) return -1;

        Dictionary<int, (long min, long max)> xLine = new(), yLine = new();
        long minX = long.MaxValue, maxX = long.MinValue;
        long minY = long.MaxValue, maxY = long.MinValue;

        foreach (var coord in A)
        {
            int x = coord[0], y = coord[1];

            if (!xLine.ContainsKey(x))
                xLine[x] = (y, y);
            else
                xLine[x] = (Math.Min(xLine[x].min, y), Math.Max(xLine[x].max, y));

            if (!yLine.ContainsKey(y))
                yLine[y] = (x, x);
            else
                yLine[y] = (Math.Min(yLine[y].min, x), Math.Max(yLine[y].max, x));

            minX = Math.Min(minX, x);
            maxX = Math.Max(maxX, x);
            minY = Math.Min(minY, y);
            maxY = Math.Max(maxY, y);
        }

        long maxArea = 0;
        foreach (var kvp in xLine)
        {
            int x = kvp.Key;
            long minYLine = kvp.Value.min;
            long maxYLine = kvp.Value.max;

            if (minYLine == maxYLine) continue;

            long height = 0;
            height = Math.Max(height, Math.Abs(minX - x));
            height = Math.Max(height, Math.Abs(maxX - x));

            maxArea = Math.Max(maxArea, (maxYLine - minYLine) * height);
        }

        foreach (var kvp in yLine)
        {
            int y = kvp.Key;
            long minXLine = kvp.Value.min;
            long maxXLine = kvp.Value.max;

            if (minXLine == maxXLine) continue;

            long height = 0;
            height = Math.Max(height, Math.Abs(minY - y));
            height = Math.Max(height, Math.Abs(maxY - y));

            maxArea = Math.Max(maxArea, (maxXLine - minXLine) * height);
        }

        return maxArea > 0 ? maxArea : -1;
    }
}