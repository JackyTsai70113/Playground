namespace playground.HashTables;

public class SimilarPairsClass
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-of-similar-strings
    /// </summary>
    public static int SimilarPairs(string[] words)
    {
        var d = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            var str = new string(new HashSet<char>(words[i]).ToList().OrderBy(x => x).ToArray());
            d[str] = d.ContainsKey(str) ? d[str] + 1 : 1;
        }
        var res = 0;
        foreach (var v in d.Values)
        {
            if (v > 1)
                res += v * (v - 1) / 2;
        }
        return res;
    }
}
