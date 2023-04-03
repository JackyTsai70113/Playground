namespace playground;

public class Solution
{
    public static int MakeConnected(int n, int[][] A)
    {
        if (A.Length < n - 1)
        {
            return -1;
        }
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var a in A)
        {
            graph[a[0]].Add(a[1]);
            graph[a[1]].Add(a[0]);
        }

        var seen = new bool[n];
        void dfs(int x)
        {
            seen[x] = true;
            foreach (var neighbor in graph[x])
            {
                if (!seen[neighbor])
                {
                    dfs(neighbor);
                }
            }
        }

        var componentsCount = -1;
        for (int i = 0; i < n; ++i)
        {
            if (!seen[i])
            {
                componentsCount++;
                dfs(i);
            }
        }
        return componentsCount;
    }

    public static long CountPairs(int n, int[][] edges)
    {
        var graph = Enumerable.Range(0, n).Select(x => new List<int>()).ToArray();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        var seen = new bool[n];
        List<int> components = new();

        int dfs(int i)
        {
            if (seen[i])
            {
                return 0;
            }
            seen[i] = true;
            var count = 1;
            foreach (var nei in graph[i])
            {
                count += dfs(nei);
            }
            return count;
        }

        long res = 0;
        long count = 0;
        for (int i = 0; i < n; ++i)
        {
            if (!seen[i])
            {
                long componentsCount = dfs(i);
                count += componentsCount;
                res += componentsCount * (n - count);
            }
        }
        return res;
    }
}
