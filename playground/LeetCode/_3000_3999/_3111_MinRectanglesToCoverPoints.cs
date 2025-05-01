namespace playground;

public class _3111_MinRectanglesToCoverPoints
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-rectangles-to-cover-points
    /// </summary>
    public static int MinRectanglesToCoverPoints(int[][] A, int w)
    {
        Array.Sort(A, (x, y) => x[0] - y[0]);
        int res = 0;
        int min = -1;
        foreach (var a in A)
        {
            if (a[0] > min)
            {
                res++;
                min = a[0] + w;
            }
        }
        return res;
    }
}
