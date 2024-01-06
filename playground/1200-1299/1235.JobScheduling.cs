namespace playground;

public class JobScheduling1235
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-profit-in-job-scheduling
    /// </summary>
    public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var jobs = Enumerable.Range(0, startTime.Length)
            .Select(i => (start: startTime[i], end: endTime[i], p: profit[i]))
            .OrderBy(x => x.end)
            .ToArray();
        var dp = new List<(int end, int p)>();
        dp.Add((0, 0));
        foreach (var job in jobs)
        {
            var (start, end, p) = job;
            int l = 0, r = dp.Count - 1;
            while (l < r)
            {
                int m = l + (r - l + 1) / 2;
                if (dp[m].end <= start)
                {
                    l = m;
                }
                else
                {
                    r = m - 1;
                }
            }
            if (dp[l].p + p > dp[^1].p)
                dp.Add((end, dp[l].p + p));
        }
        return dp[^1].p;
    }
}
