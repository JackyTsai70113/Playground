namespace playground;

public class MaximumRemovals_1898
{
    public static int MaximumRemovals(string s, string p, int[] rs)
    {
        int l = 0, r = rs.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (isSubseq(s, p, rs, m))
                l = m;
            else
                r = m - 1;
        }
        if (isSubseq(s, p, rs, l)) l++;
        return l;
    }
    static bool isSubseq(string s, string p, int[] rs, int end)
    {
        var set = rs.Take(end + 1).ToHashSet();
        int si = 0, pi = 0;
        while (pi < p.Length)
        {
            while (set.Contains(si)) si++;
            if (si == s.Length) break;
            if (s[si] == p[pi])
            {
                pi++;
            }
            si++;
        }
        return pi == p.Length;
    }
}
