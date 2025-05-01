namespace playground.LeetCode._2000_2999;

public class _2747_CountServers
{
    /// <summary>
    /// https://leetcode.com/problems/count-zero-request-servers
    /// </summary>
    public static int[] CountServers(int n, int[][] logs, int x, int[] queries)
    {
        logs = logs.OrderBy(log => log[1]).ToArray();
        var arr = queries
            .Select((x, i) => new int[] { x, i })
            .OrderBy(y => y[0])
            .ToArray();
        int m = logs.Length, l = 0, r = 0, count = 0;
        var d = new Dictionary<int, int>();
        var res = new int[queries.Length];
        foreach (var q in arr)
        {
            while (r < m && logs[r][1] <= q[0])
            {
                d[logs[r][0]] = 1 + (d.ContainsKey(logs[r][0]) ? d[logs[r][0]] : 0);
                if(d[logs[r][0]] == 1)
                    count++;
                r++;
            }
            while (logs[l][1] < q[0] - x)
            {
                d[logs[l][0]]--;
                if(d[logs[l][0]] == 0)
                    count--;
                l++;
            }
            res[q[1]] = n - count;
        }
        return res;
    }
}
