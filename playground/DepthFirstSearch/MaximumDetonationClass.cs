namespace playground.DepthFirstSearch;

public class MaximumDetonationClass
{
    /// <summary>
    /// https://leetcode.com/problems/detonate-the-maximum-bombs
    /// </summary>
    public static int MaximumDetonation(int[][] bs)
    {
        int n = bs.Length;
        var graph = new List<int>[n];
        for (int i = 0; i < n; ++i)
        {
            graph[i] = new List<int>();
            for (int j = 0; j < n; ++j)
            {
                if (i == j) continue;
                long x = bs[i][0] - bs[j][0];
                long y = bs[i][1] - bs[j][1];
                long r = bs[i][2];
                if (r * r >= x * x + y * y)
                    graph[i].Add(j);
            }
        }
        bool[] seen;
        int count, res = 0;
        void dfs(int i)
        {
            if (seen[i]) return;
            seen[i] = true;
            count++;
            foreach (var nei in graph[i])
                dfs(nei);
        }

        for (int i = 0; i < n; ++i)
        {
            seen = new bool[n];
            count = 0;
            dfs(i);
            res = Math.Max(res, count);
        }
        return res;
    }
}
