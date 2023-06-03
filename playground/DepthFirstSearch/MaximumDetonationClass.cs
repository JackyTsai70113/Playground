using System.Security;

namespace playground.DepthFirstSearch;

public class MaximumDetonationClass
{
    public int MaximumDetonation(int[][] bs)
    {
        Array.Sort(bs, (x, y) => y[2] - x[2]);
        int n = bs.Length;
        var graph = new List<int>[n];
        for (int i = 0; i < n; ++i)
        {
            graph[i] = new List<int>();
            for (int j = i + 1; j < n; ++j)
            {
                long x = bs[i][0] - bs[j][0];
                long y = bs[i][1] - bs[j][1];
                long r = bs[i][2];
                if (r * r > x * x + y * y)
                    graph[i].Add(j);
            }
        }
        var seen = new bool[n];
        int res = 0, cnt = 0;
        for (int i = 0; i < n; ++i)
        {
            seen[0] = true;
            cnt = 1;
            for (int j = i; j < n; ++j)
            {
                if (!seen[j]) continue;
                foreach (var nei in graph[j])
                {
                    if (seen[nei]) continue;
                    seen[nei] = true;
                    cnt++;
                }
            }
            res = Math.Max(res, cnt);
        }
        return res;
    }
}
