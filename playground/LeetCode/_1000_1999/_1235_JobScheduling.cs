namespace playground.LeetCode._1000_1999;

public class _1235_JobScheduling
{
    public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var jobs = Enumerable.Range(0, startTime.Length)
            .Select(i => (start: startTime[i], end: endTime[i], p: profit[i]))
            .OrderBy(j => j.end)
            .ToArray();
        var dp = new List<(int end, int p)> { (0, 0) };
        foreach (var (start, end, p) in jobs)
        {
            int l = 0, r = dp.Count - 1;
            while (l < r)
            {
                int m = l + (r - l + 1) / 2;
                if (dp[m].end <= start)
                    l = m;
                else
                    r = m - 1;
            }
            int newProfit = dp[l].p + p;
            if (newProfit > dp[^1].p)
            {
                dp.Add((end, newProfit));
            }
        }
        return dp[^1].p;
    }
}
