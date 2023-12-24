namespace playground;

public class FindContentChildren0455
{
    /// <summary>
    /// https://leetcode.com/problems/assign-cookies
    /// </summary>
    public static int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int gi = 0;
        for (int si = 0; gi < g.Length && si < s.Length; ++si)
        {
            if (g[gi] <= s[si]) gi++;
        }
        return gi;
    }
}
