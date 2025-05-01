namespace playground;

public class _3207_MaximumPoints
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-points-after-enemy-battles
    /// </summary>
    public static long MaximumPoints(int[] A, int e)
    {
        long res = e;
        int min = A.Min();
        if (res < min) return 0;
        res -= min;
        foreach (var a in A)
        {
            res += a;
        }
        return res / min;
    }
}
