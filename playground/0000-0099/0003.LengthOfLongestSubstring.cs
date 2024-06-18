namespace playground;

public class LengthOfLongestSubstring0003
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters
    /// </summary>
    public static int LengthOfLongestSubstring(string s)
    {
        var chs = new bool[256];
        int res = 0;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            while (chs[s[r]])
                chs[s[l++]] = false;
            chs[s[r]] = true;
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
