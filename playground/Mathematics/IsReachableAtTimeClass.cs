namespace playground.Mathematics;

public class IsReachableAtTimeClass
{
    /// <summary>
    /// https://leetcode.com/problems/determine-if-a-cell-is-reachable-at-a-given-time
    /// </summary>
    public static bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        int max = Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy));
        if (max == 0) return t == 0 || t >= 2;
        return t >= max;
    }
}
