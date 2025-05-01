namespace playground.LeetCode._2000_2999;

public class _2392_BuildMatrix
{
    public static int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
    {
        var rowSorted = TopSort(k, rowConditions);
        var colSorted = TopSort(k, colConditions);
        var res = new int[k][];
        for (int i = 0; i < k; i++) res[i] = new int[k];
        if (rowSorted == null || colSorted == null)
            return new int[0][];
        for (int i = 1; i <= k; i++)
        {
            res[rowSorted[i]][colSorted[i]] = i;
        }
        return res;
    }

    static Dictionary<int, int> TopSort(int k, int[][] edges)
    {
        List<int>[] g = new List<int>[k + 1];
        int[] indegrees = new int[k + 1];
        for (int i = 1; i <= k; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            indegrees[e[1]]++;
        }
        var q = new Queue<int>();
        for (int i = 1; i <= k; i++)
            if (indegrees[i] == 0)
                q.Enqueue(i);
        int idx = 0;
        var res = new Dictionary<int, int>();
        while (q.TryDequeue(out int u))
        {
            res[u] = idx++;
            foreach (var v in g[u])
                if (--indegrees[v] == 0)
                    q.Enqueue(v);
        }
        if (idx != k) return null;
        return res;
    }
}
