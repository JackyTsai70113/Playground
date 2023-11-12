namespace playground;

public class MinOperations_2896
{
    /// <summary>
    /// https://leetcode.com/problems/apply-operations-to-make-two-strings-equal
    /// </summary>
    public static int MinOperations(string s1, string s2, int x)
    {
        var l = Enumerable.Range(0, s1.Length).Where(i => s1[i] != s2[i]).ToList();
        if (l.Count == 0) return 0;
        if (l.Count % 2 == 1) return -1;
        double pre = 0, cur = (double)x / 2;
        for (int i = 1; i < l.Count; i++)
        {
            (pre, cur) = (cur, Math.Min(l[i] - l[i - 1] + pre, cur + x / 2));
        }
        return (int)cur;
    }
}
