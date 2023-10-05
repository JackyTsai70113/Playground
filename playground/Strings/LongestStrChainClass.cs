namespace playground.Strings;

public class LongestStrChainClass
{
    /// <summary>
    /// https://leetcode.com/problems/longest-string-chain
    /// </summary>
    public static int LongestStrChain(string[] words)
    {
        Array.Sort(words, (x, y) => x.Length - y.Length);
        var d = new Dictionary<string, int>();
        int res = 0;
        foreach (var w in words)
        {
            if (!d.ContainsKey(w))
                d[w] = 1;
            for (int i = 0; i < w.Length; ++i)
            {
                var w2 = w[..i] + w[(i + 1)..];
                if (d.ContainsKey(w2))
                    d[w] = Math.Max(d[w], d[w2] + 1);
            }
            res = Math.Max(res, d[w]);
        }
        return res;
    }
}
