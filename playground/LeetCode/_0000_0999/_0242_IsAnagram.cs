namespace playground.LeetCode._0000_0999;

public class _0242_IsAnagram
{
    /// <summary>
    /// https://leetcode.com/problems/valid-anagram
    /// </summary>
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var memo = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            memo[s[i] - 'a']++;
            memo[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (memo[i] != 0)
                return false;
        }
        return true;
    }
}
