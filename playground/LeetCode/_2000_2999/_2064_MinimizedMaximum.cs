namespace playground.LeetCode._2000_2999;

public class _2064_MinimizedMaximum_cs
{
    public static int MinimizedMaximum(int n, int[] qs)
    {
        int l = 1, r = qs.Max();
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (IsValid(m, n, qs))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    public static bool IsValid(int max, int n, int[] qs)
    {
        int basketCount = 0;
        foreach (var q in qs)
        {
            basketCount += (q + max - 1) / max;
        }
        return basketCount <= n;
    }
}
