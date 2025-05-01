namespace playground._1700_1799;

public class _1718_ConstructDistanceSequence_cs
{
    public static int[] ConstructDistancedSequence(int n)
    {
        var res = new int[n * 2 - 1];
        Bt(n, 0, res, new bool[n + 1]);
        return res;
    }

    static bool Bt(int n, int start, int[] res, bool[] seen)
    {
        if (start == res.Length)
            return true;
        if (res[start] != 0)
            return Bt(n, start + 1, res, seen);
        for (int i = n; i >= 1; i--)
        {
            if (seen[i])
                continue;
            seen[i] = true;
            res[start] = i;
            if (i == 1)
            {
                if (Bt(n, start + 1, res, seen))
                    return true;
            }
            else if (i + start < res.Length && res[start + i] == 0)
            {
                res[start + i] = i;
                if (Bt(n, start + 1, res, seen))
                    return true;
                res[start + i] = 0;
            }
            res[start] = 0;
            seen[i] = false;
        }
        return false;
    }
}
