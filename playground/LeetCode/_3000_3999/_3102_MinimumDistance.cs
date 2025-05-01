namespace playground;

public class _3102_MinimumDistance
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-manhattan-distances
    /// </summary>
    public static int MinimumDistance(int[][] pts)
    {
        var (imin, imax) = MaxManhattanDistance(pts, -1);
        var (imin1, imax1) = MaxManhattanDistance(pts, imin);
        var (imin2, imax2) = MaxManhattanDistance(pts, imax);
        return Math.Min(Manhattan(pts[imin1], pts[imax1]),
            Manhattan(pts[imin2], pts[imax2]));
    }

    private static (int imin, int imax) MaxManhattanDistance(int[][] pts, int ignoreIndex)
    {
        int iMinSum = -1, iMaxSum = -1, iMinDiff = -1, iMaxDiff = -1;
        int minSum = int.MaxValue, maxSum = int.MinValue;
        int minDiff = int.MaxValue, maxDiff = int.MinValue;
        for (int i = 0; i < pts.Length; i++)
        {
            if (i == ignoreIndex) continue;
            int sum = pts[i][0] + pts[i][1], diff = pts[i][0] - pts[i][1];
            if (sum < minSum)
            {
                iMinSum = i;
                minSum = sum;
            }
            if (sum > maxSum)
            {
                iMaxSum = i;
                maxSum = sum;
            }
            if (diff < minDiff)
            {
                iMinDiff = i;
                minDiff = diff;
            }
            if (diff > maxDiff)
            {
                iMaxDiff = i;
                maxDiff = diff;
            }
        }
        if (maxSum - minSum > maxDiff - minDiff)
        {
            return (iMinSum, iMaxSum);
        }
        else
        {
            return (iMinDiff, iMaxDiff);
        }
    }
    public static int Manhattan(int[] pt1, int[] pt2)
    {
        return Math.Abs(pt1[0] - pt2[0]) + Math.Abs(pt1[1] - pt2[1]);
    }
}