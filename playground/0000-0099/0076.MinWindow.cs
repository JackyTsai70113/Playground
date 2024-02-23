namespace playground;

public class MinWindow0076
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-window-substring
    /// </summary>
    public static string MinWindow(string s, string t)
    {
        int resl = 0, resr = int.MaxValue, counter = 0;
        int[] chs = new int[128], chs2 = new int[128]; // hash map
        foreach (var c in t)
            chs2[c]++;
        for (int l = 0, r = 0; r < s.Length; ++r)
        {
            chs[s[r]]++;
            if (chs[s[r]] <= chs2[s[r]])
                counter++;
            while (l < s.Length && chs[s[l]] > chs2[s[l]])
                chs[s[l++]]--;
            if (counter == t.Length && resr - resl > r - l)
            {
                resl = l;
                resr = r;
            }
        }
        return resr == int.MaxValue ? string.Empty : s.Substring(resl, resr - resl + 1);
    }
}
