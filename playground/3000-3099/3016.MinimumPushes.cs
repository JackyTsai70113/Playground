namespace playground;

public class MinimumPushes3016
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii
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
            res += chs[i] * ((chs.Length - i - 1) / 8 + 1);
        }
        return res;
    }
}
