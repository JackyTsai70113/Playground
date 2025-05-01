namespace playground;

public class _1335_MinDifficulty
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule
    /// </summary>
    public static int MinDifficulty(int[] jobs, int d)
    {
        int n = jobs.Length;
        var memo = new int[d + 1, n];
        for (int i = 0; i < d + 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[i, j] = int.MaxValue;
            }
        }
        int dfs(int leftDays, int jobStart)
        {
            if (memo[leftDays, jobStart] != int.MaxValue)
                return memo[leftDays, jobStart];
            int res;
            if (jobStart == n - 1)
            {
                res = leftDays == 1 ? jobs[jobStart] : -1;
            }
            else if (leftDays > n - jobStart)
            {
                res = -1;
            }
            else if (leftDays == 1)
            {
                res = 0;
                for (int i = jobStart; i < n; ++i)
                {
                    res = Math.Max(res, jobs[i]);
                }
            }
            else
            {
                int curMax = 0;
                res = int.MaxValue;
                for (int i = jobStart; i < n - 1; ++i)
                {
                    curMax = Math.Max(curMax, jobs[i]);
                    int next = dfs(leftDays - 1, i + 1);
                    if (next != -1)
                        res = Math.Min(res, curMax + next);
                }
            }
            return memo[leftDays, jobStart] = res;
        }
        return dfs(d, 0);
    }
}
