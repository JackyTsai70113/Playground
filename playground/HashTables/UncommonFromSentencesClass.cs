namespace playground.HashTables;

public class UncommonFromSentencesClass
{
    /// <remarks>https://leetcode.com/problems/uncommon-words-from-two-sentences</remarks>
    public static string[] UncommonFromSentences(string s1, string s2)
    {
        var d = new Dictionary<string, int>();
        foreach (var str in s1.Split(' '))
        {
            d[str] = d.ContainsKey(str) ? d[str] + 1 : 1;
        }
        foreach (var str in s2.Split(' '))
        {
            d[str] = d.ContainsKey(str) ? d[str] + 1 : 1;
        }
        var res = new List<string>();
        foreach (var k in d.Keys)
        {
            if (d[k] == 1)
            {
                res.Add(k);
            }
        }
        return res.ToArray();
    }
}
