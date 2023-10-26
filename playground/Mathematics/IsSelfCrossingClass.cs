namespace playground.Mathematics;

public class IsSelfCrossingClass
{
    /// <summary>
    /// https://leetcode.com/problems/self-crossing
    /// </summary>
    public static bool IsSelfCrossing(int[] ds)
    {
        bool isCrossing(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            if (p1[0] == p2[0])
                return isCrossing(p3, p4, p1, p2);
            return Math.Min(p1[0], p2[0]) <= p3[0] && p3[0] <= Math.Max(p1[0], p2[0]) &&
                Math.Min(p3[1], p4[1]) <= p1[1] && p1[1] <= Math.Max(p3[1], p4[1]);
        }

        bool IsSameLine(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            if (p1[0] == p2[0] && p2[0] == p3[0] && p3[0] == p4[0])
            {
                if (Math.Max(p3[1], p4[1]) >= Math.Min(p1[1], p2[1])
                    && Math.Max(p1[1], p2[1]) >= Math.Min(p3[1], p4[1]))
                    return true;
            }
            if (p1[1] == p2[1] && p2[1] == p3[1] && p3[1] == p4[1])
            {
                if (Math.Max(p3[0], p4[0]) >= Math.Min(p1[0], p2[0])
                    && Math.Max(p1[0], p2[0]) >= Math.Min(p3[0], p4[0]))
                    return true;
            }
            return false;
        } 

        var ps = new int[7][];
        ps[0] = new int[2];
        for (int i = 0; i < ds.Length; ++i)
        {
            var cur = ps[i % 7];
            var before2 = ps[(i + 5) % 7];
            var before3 = ps[(i + 4) % 7];
            var before4 = ps[(i + 3) % 7];
            var before5 = ps[(i + 2) % 7];
            var next = cur.ToArray();

            switch (i % 4)
            {
                case 0:
                    next[1] += ds[i];
                    break;
                case 1:
                    next[0] -= ds[i];
                    break;
                case 2:
                    next[1] -= ds[i];
                    break;
                default:
                    next[0] += ds[i];
                    break;
            }
            ps[(i + 1) % 7] = next.ToArray();

            if (i >= 3 && isCrossing(before3, before2, cur, next))
            {
                return true;
            }
            if (i >= 4 && IsSameLine(before4, before3, cur, next))
            {
                return true;
            }
            if (i >= 5 && isCrossing(before5, before4, cur, next))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// https://leetcode.com/problems/self-crossing
    /// </summary>
    public static bool IsSelfCrossing2(int[] ds)
    {
        for (int i = 3; i < ds.Length; ++i)
        {
            if (ds[i] >= ds[i - 2] && ds[i - 1] <= ds[i - 3])
                return true;
            if (i >= 4 && ds[i] + ds[i - 4] >= ds[i - 2] && ds[i - 1] == ds[i - 3])
                return true;
            if (i >= 5 && ds[i] + ds[i - 4] >= ds[i - 2] && ds[i - 2] >= ds[i - 4]
                && ds[i - 1] + ds[i - 5] >= ds[i - 3] && ds[i - 3] >= ds[i - 1])
                return true;
        }
        return false;
    }
}
