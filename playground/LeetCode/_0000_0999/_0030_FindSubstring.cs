namespace playground.LeetCode._0000_0999;

public class _0030_FindSubstring
{
    /// <summary>
    /// https://leetcode.com/problems/substring-with-concatenation-of-all-words
    /// </summary>
    public static IList<int> FindSubstring(string s, string[] words)
    {
        var wordDict = new Dictionary<string, int>();
        foreach (var w in words)
        {
            wordDict[w] = wordDict.ContainsKey(w) ? wordDict[w] + 1 : 1;
        }
        int n = words.Length, wl = words[0].Length, count = 0;
        var counter = new Dictionary<string, int>();
        var res = new List<int>();
        for (int i = 0; i < wl; i++)
        {
            int left = i;
            count = 0;
            counter.Clear();
            for (int j = i; j <= s.Length - wl; j += wl)
            {
                var word = s.Substring(j, wl);
                if (wordDict.ContainsKey(word))
                {
                    counter[word] = counter.ContainsKey(word) ? counter[word] + 1 : 1;
                    if (counter[word] <= wordDict[word])
                    {
                        count++;
                    }
                    else
                    {
                        while (counter[word] > wordDict[word])
                        {
                            var word2 = s.Substring(left, wl);
                            counter[word2]--;
                            left += wl;
                            if (counter[word2] < wordDict[word2])
                                count--;
                        }
                    }
                    if (count == n)
                    {
                        res.Add(left);
                        count--;
                        counter[s.Substring(left, wl)]--;
                        left += wl;
                    }
                }
                else
                {
                    count = 0;
                    counter.Clear();
                    left = j + wl;
                }
            }
        }
        return res;
    }
}
