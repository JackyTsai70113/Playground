namespace playground;

public class FindExit_f581
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=f581
    /// /// </summary>
    public static int FindExit(int[] rooms, int[] missions)
    {
        int m = rooms.Length, n = missions.Length;
        var presum = rooms.ToArray();
        for (int i = 1; i < m; i++)
            presum[i] += presum[i - 1];
        int last = -1;
        for (int i = 0; i < n; i++)
        {
            var target = missions[i];
            if (last != -1)
                target += presum[last];
            if (target > presum[^1])
                target -= presum[^1];
            int l = 0, r = m;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (presum[mid] >= target)
                    r = mid;
                else
                    l = mid + 1;
            }
            last = l;
        }
        return (last + 1) % m;
    }
}
