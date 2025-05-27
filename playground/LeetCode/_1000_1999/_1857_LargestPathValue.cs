namespace playground.LeetCode._1000_1999;

public class _1857_LargestPathValue
{
    public static int LargestPathValue(string colors, int[][] edges)
    {
        int n = colors.Length;

        var g = new List<int>[n];
        var indegree = new int[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            if (e[0] == e[1]) return -1;
            g[e[0]].Add(e[1]);
            indegree[e[1]]++;
        }

        var count = new int[n, 26];
        for (int i = 0; i < n; i++)
        {
            count[i, colors[i] - 'a']++;
        }

        var visited = 0;
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (indegree[i] == 0)
            {
                visited++;
                q.Enqueue(i);
            }
        }

        int max = 0;
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            for (int j = 0; j < 26; j++)
            {
                max = Math.Max(max, count[u, j]);
            }
            foreach (var v in g[u])
            {
                int color = colors[v] - 'a';
                for (int i = 0; i < 26; i++)
                {
                    int append = color == i ? 1 : 0;
                    count[v, i] = Math.Max(count[v, i], count[u, i] + append);
                }
                indegree[v]--;
                if (indegree[v] == 0)
                {
                    visited++;
                    q.Enqueue(v);
                }
            }
        }
        return visited != n ? -1 : max;
    }
}
