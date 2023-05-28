namespace playground.DirectedGraph;

public class LadderLengthClass
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder
    /// </summary>
    public static int LadderLength(string beginWord, string endWord, IList<string> ws)
    {
        if (ws.IndexOf(endWord) == -1) return 0;
        ws = ws.Append(beginWord).ToList();
        int m = ws.Count, n = ws[0].Length, diffs;
        var graph = new Dictionary<string, List<string>>();
        for (int i = 0; i < m; i++)
        {
            if (!graph.ContainsKey(ws[i]))
                graph[ws[i]] = new List<string>();
            for (int j = i + 1; j < m; j++)
            {
                diffs = 0;
                for (int k = 0; diffs < 2 && k < n; ++k)
                {
                    if (ws[i][k] != ws[j][k])
                        diffs++;
                }
                if (diffs != 1)
                    continue;
                if (!graph.ContainsKey(ws[j]))
                    graph[ws[j]] = new List<string>();
                graph[ws[i]].Add(ws[j]);
                graph[ws[j]].Add(ws[i]);
            }
        }

        var step = 1;
        var seen = new HashSet<string>();
        var q = new Queue<string>();
        q.Enqueue(beginWord);
        seen.Add(beginWord);
        while (q.Count > 0)
        {
            step++;
            for (int i = q.Count; i > 0; --i)
            {
                var u = q.Dequeue();
                foreach (var v in graph[u])
                {
                    if (v == endWord)
                        return step;
                    if (seen.Contains(v))
                    {
                        continue;
                    }
                    seen.Add(v);
                    q.Enqueue(v);
                }
            }
        }
        return 0;
    }
}
