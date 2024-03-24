namespace playground;

public class MaximumLengthSubstring3090
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-substring-with-two-occurrences
    /// </summary>
    public static int MaximumLengthSubstring(string s)
    {
        int res = 0;
        var chs = new int[26];
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            chs[s[r] - 'a']++;
            while (chs[s[r] - 'a'] > 2) chs[s[l++] - 'a']--;
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
