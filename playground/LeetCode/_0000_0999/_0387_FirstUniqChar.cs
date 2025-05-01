namespace playground.LeetCode._0000_0999;

public class _0387_FirstUniqChar
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string
    /// </summary>
    public static int FirstUniqChar(string s)
    {
        var chs = new int[26];
        foreach (var c in s)
            chs[c - 'a']++;
        for (int i = 0; i < s.Length; i++)
            if (chs[s[i] - 'a'] == 1)
                return i;
        return -1;
    }
}
