namespace playground;

public class _3000_AreaOfMaxDiagonal
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-area-of-longest-diagonal-rectangle
    /// </summary>
    public static int AreaOfMaxDiagonal(int[][] dimensions)
    {
        int res = 0, dia = 0;
        foreach (var d in dimensions)
        {
            if (d[0] * d[0] + d[1] * d[1] > dia)
            {
                dia = d[0] * d[0] + d[1] * d[1];
                res = d[0] * d[1];
            }
            else if (d[0] * d[0] + d[1] * d[1] == dia)
            {
                res = Math.Max(res, d[0] * d[1]);
            }
        }
        return res;
    }
}
