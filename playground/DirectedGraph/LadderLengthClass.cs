namespace playground.DirectedGraph;

public class LadderLengthClass
{
    public static int LadderLength(string beginWord, string endWord, IList<string> ws)
    {
        if (ws.IndexOf(endWord) == -1)
            return 0;
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

        if (!graph.ContainsKey(beginWord))
            graph[beginWord] = new List<string>();
        for (int j = 0; j < m; j++)
        {
            diffs = 0;
            for (int k = 0; diffs < 2 && k < n; ++k)
            {
                if (beginWord[k] != ws[j][k])
                    diffs++;
            }
            if (diffs != 1)
                continue;
            if (!graph.ContainsKey(ws[j]))
                graph[ws[j]] = new List<string>();
            graph[beginWord].Add(ws[j]);
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
