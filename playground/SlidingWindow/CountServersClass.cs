namespace playground.SlidingWindow;

public class CountServersClass
{
    public static int[] CountServers(int n, int[][] logs, int x, int[] queries)
    {
        logs = logs.OrderBy(l => l[1]).ToArray();
        var qs = queries.Select((q, i) => (q, i)).OrderBy(x => x.q).ToArray();
        var res = new int[qs.Length];
        var d = new Dictionary<int, int>();
        int l = 0, r = 0;
        foreach (var (q, i) in qs)
        {
            while (r < logs.Length && logs[r][1] <= q)
            {
                d[logs[r][0]] = d.TryGetValue(logs[r][0], out int v) ? v + 1 : 1;
                r++;
            }
            while (l < logs.Length && logs[l][1] < q - x)
            {
                d[logs[l][0]]--;
                if (d[logs[l][0]] == 0) d.Remove(logs[l][0]);
                l++;
            }
            res[i] = n - d.Keys.Count;
        }
        return res;
    }
}
