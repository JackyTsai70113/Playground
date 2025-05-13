namespace playground.LeetCode._1000_1999;

public class _1657_CloseStrings
{
    /// <summary>
    /// https://leetcode.com/problems/determine-if-two-strings-are-close
    /// </summary>
    public static bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;
        int[] chs1 = new int[26], chs2 = new int[26];
        bool[] exist1 = new bool[26], exist2 = new bool[26];
        for (int i = 0; i < word1.Length; i++)
        {
            chs1[word1[i] - 'a']++;
            chs2[word2[i] - 'a']++;
            exist1[word1[i] - 'a'] = true;
            exist2[word2[i] - 'a'] = true;
        }
        Array.Sort(chs1);
        Array.Sort(chs2);
        return chs1.SequenceEqual(chs2) &&
            exist1.SequenceEqual(exist2);
    }
}
