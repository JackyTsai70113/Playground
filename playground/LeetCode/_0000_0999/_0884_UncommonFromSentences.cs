namespace playground.LeetCode._0000_0999;

public class _0884_UncommonFromSentences
{
    /// <summary>
    /// https://leetcode.com/problems/uncommon-words-from-two-sentences
    /// </summary>
    public static string[] UncommonFromSentences(string s1, string s2)
    {
        var d = new Dictionary<string, int>();
        foreach (var s in s1.Split(' '))
        {
            d[s] = d.ContainsKey(s) ? d[s] + 1 : 1;
        }
        foreach (var s in s2.Split(' '))
        {
            d[s] = d.ContainsKey(s) ? d[s] + 1 : 1;
        }
        return d.Keys.Where(k => d[k] == 1).ToArray();
    }
}
