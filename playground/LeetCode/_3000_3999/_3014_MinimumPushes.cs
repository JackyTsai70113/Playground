namespace playground;

public class _3014_MinimumPushes
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-i
    /// </summary>
    public static int MinimumPushes(string word)
    {
        var chs = new int[26];
        foreach (var c in word)
        {
            chs[c - 'a']++;
        }
        chs = chs.Where(x => x != 0).OrderBy(x => x).ToArray();
        var res = 0;
        for (int i = chs.Length - 1; i >= 0; --i)
        {
            res += (chs.Length - i - 1) / 8 + 1;
        }
        return res;
    }
}
