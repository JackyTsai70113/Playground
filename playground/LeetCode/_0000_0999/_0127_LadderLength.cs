namespace playground.LeetCode._0000_0999;

public class _0127_LadderLength
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder
    /// </summary>
    public static int LadderLength(string beginWord, string endWord, IList<string> ws)
    {
        ws = ws.Append(beginWord).ToList();
        var g = new Dictionary<string, List<string>>();
        for (int i = 0; i < ws.Count; i++)
            g[ws[i]] = new();
        for (int i = 0; i < ws.Count; i++)
        {
            for (int j = i + 1; j < ws.Count; j++)
            {
                int diff = 0;
                for (int k = 0; diff <= 2 && k < beginWord.Length; k++)
                {
                    if (ws[i][k] != ws[j][k])
                        diff++;
                }
                if (diff == 1)
                {
                    g[ws[i]].Add(ws[j]);
                    g[ws[j]].Add(ws[i]);
                }
            }
        }
        Queue<string> q = new();
        HashSet<string> seen = new();
        int step = 0;
        q.Enqueue(beginWord);
        seen.Add(beginWord);
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                var u = q.Dequeue();
                if (u == endWord)
                    return step + 1;
                foreach (var v in g[u])
                {
                    if (!seen.Contains(v))
                    {
                        q.Enqueue(v);
                        seen.Add(v);
                    }
                }
            }
            step++;
        }

        return 0;
    }

    public static int LadderLength2(string beginWord, string endWord, IList<string> ws)
    {
        var set = ws.ToHashSet();
        if (!set.Contains(endWord)) return 0;
        Queue<string> q = new();
        int step = 0;
        q.Enqueue(beginWord);
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                var u = q.Dequeue();
                if (u == endWord) return step + 1;
                var chs = u.ToCharArray();
                for (int j = 0; j < chs.Length; j++)
                {
                    var temp = chs[j];
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        chs[j] = c;
                        var str = new string(chs);
                        if (set.Contains(str))
                        {
                            set.Remove(str);
                            q.Enqueue(str);
                        }
                    }
                    chs[j] = temp;
                }
            }
            step++;
        }
        return 0;
    }
}
