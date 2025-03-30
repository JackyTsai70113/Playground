using System.Text;

namespace playground;

public class Spellchecker0966
{
    /// <summary>
    /// https://leetcode.com/problems/vowel-spellchecker
    /// </summary>
    public static string[] Spellchecker(string[] wordlist, string[] queries)
    {
        Dictionary<string, string> d = new();
        HashSet<string> set = wordlist.ToHashSet();
        foreach (var w in wordlist)
        {
            var lowerW = w.ToLower();
            if (!d.ContainsKey(lowerW))
                d[lowerW] = w;
            var devowelW = Devowel(lowerW);
            if (!d.ContainsKey(devowelW))
                d[devowelW] = w;
        }
        for (int i = 0; i < queries.Length; i++)
        {
            if (set.Contains(queries[i])) continue;
            else if (d.ContainsKey(queries[i].ToLower()))
                queries[i] = d[queries[i].ToLower()];
            else if (d.ContainsKey(Devowel(queries[i])))
                queries[i] = d[Devowel(queries[i])];
            else
                queries[i] = string.Empty;
        }
        return queries;
    }

    public static string Devowel(string s)
    {
        var chs = s.ToLower().ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (chs[i] == 'a' || chs[i] == 'e' || chs[i] == 'i' || chs[i] == 'o' || chs[i] == 'u')
                chs[i] = '0';
        }
        return new string(chs);
    }
}
