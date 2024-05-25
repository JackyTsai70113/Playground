using System.Text;

namespace playground;

public class WordBreak0140
{
    /// <summary>
    /// https://leetcode.com/problems/word-break-ii
    /// </summary>
    public static IList<string> WordBreak(string s, IList<string> wordDict)
    {
        var set = wordDict.ToHashSet();
        var res = new List<string>();
        Bt(s, set, 0, new StringBuilder(), res);
        return res;
    }

    static void Bt(string s, HashSet<string> set, int start, StringBuilder cur, List<string> res)
    {
        if (start == s.Length)
        {
            res.Add(cur.ToString().Substring(1));
            return;
        }
        for (int i = start; i < s.Length; i++)
        {
            var str = s.Substring(start, i - start + 1);
            if (set.Contains(str))
            {
                cur.Append(" " + str);
                Bt(s, set, i + 1, cur, res);
                cur.Remove(cur.Length - str.Length - 1, str.Length + 1);
            }
        }
    }
}
