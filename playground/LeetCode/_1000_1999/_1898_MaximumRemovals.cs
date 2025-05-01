namespace playground;

public class _1898_MaximumRemovals
{
    public static int MaximumRemovals(string s, string p, int[] rs)
    {
        var ss = s.ToCharArray();
        int l = 0, r = rs.Length - 1;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (IsSubseq(s, p, rs, ss, m))
                l = m;
            else
                r = m - 1;
        }
        if (IsSubseq(s, p, rs, ss, l)) l++;
        return l;
    }
    static bool IsSubseq(string s, string p, int[] rs, char[] ss, int end)
    {
        for (int i = 0; i <= end; ++i)
            ss[rs[i]] = '.';
        int si = 0, pi = 0;
        while (pi < p.Length)
        {
            while (si < s.Length && ss[si] == '.') si++;
            if (si == s.Length) break;
            if (s[si] == p[pi]) pi++;
            si++;
        }
        for (int i = 0; i <= end; ++i)
            ss[rs[i]] = s[rs[i]];
        return pi == p.Length;
    }
}
