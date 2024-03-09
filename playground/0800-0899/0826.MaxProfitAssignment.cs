namespace playground;

public class MaxProfitAssignment0826
{
    /// <summary>
    /// https://leetcode.com/problems/most-profit-assigning-work
    /// </summary>
    public static int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        int n = difficulty.Length;
        var arr = Enumerable.Range(0, n)
            .Select(i => new int[] { difficulty[i], profit[i] })
            .OrderBy(x => x[0])
            .ToArray();
        for (int i = 1; i < n; i++)
        {
            arr[i][1] = Math.Max(arr[i][1], arr[i - 1][1]);
        }
        Array.Sort(worker);
        int l = -1, r = n - 1, res = 0;
        foreach (var w in worker)
        {
            r = n - 1;
            while (l < r)
            {
                int m = l + (r - l + 1) / 2;
                if (arr[m][0] <= w)
                {
                    l = m;
                }
                else
                {
                    r = m - 1;
                }
            }
            if (l >= 0)
            {
                res += arr[l][1];
                l--;
            }
        }
        return res;
    }
}
