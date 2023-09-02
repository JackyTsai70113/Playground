namespace playground.Strings;

public class CheckStringsClass
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-ii
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public static bool CheckStrings(string s1, string s2)
    {
        int[] a1 = new int[26], a2 = new int[26], a3 = new int[26], a4 = new int[26];
        for (int i = 0; i < s1.Length; i += 2)
        {
            a2[s1[i] - 'a']++;
            a4[s2[i] - 'a']++;
        }
        for (int i = 1; i < s1.Length; i += 2)
        {
            a1[s1[i] - 'a']++;
            a3[s2[i] - 'a']++;
        }
        for (int i = 0; i < 26; i++)
        {
            if (a2[i] != a4[i])
                return false;
            if (a1[i] != a3[i])
                return false;
        }
        return true;
    }
}
