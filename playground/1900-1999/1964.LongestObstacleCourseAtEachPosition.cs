namespace playground;

public class LongestObstacleCourseAtEachPosition1964
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position
    /// </summary>
    public static int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        var d = new Dictionary<int, int>();
        var list = new List<int>();
        var res = new List<int>();
        int l, r, m, idx;
        foreach (var ob in obstacles)
        {
            if (!d.ContainsKey(ob))
            {
                l = 0; r = list.Count;
                while (l < r)
                {
                    m = l + (r - l) / 2;
                    if (list[m] > ob)
                        r = m;
                    else
                        l = m + 1;
                }
                idx = l;
                d[ob] = idx + 1;
            }
            else
            {
                idx = d[ob];
                d[ob]++;
            }
            if (idx == list.Count)
            {
                list.Add(ob);
            }
            else if (ob < list[idx])
            {
                d.Remove(list[idx]);
                list[idx] = ob;
            }
            res.Add(d[ob]);
        }
        return res.ToArray();
    }

    public static int[] LongestObstacleCourseAtEachPosition2(int[] obstacles)
    {
        int n = obstacles.Length, len = 0;
        int[] res = new int[n], sub = new int[n];
        for (int i = 0; i < n; i++)
        {
            // 取得大於給定範圍內 sub 的第一個數的 index
            int l = 0, r = len; // 右邊界要比搜尋範圍多1
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (sub[m] > obstacles[i])
                    r = m;
                else
                    l = m + 1;
            }
            var idx = l;
            sub[idx] = obstacles[i];
            res[i] = idx + 1;
            if (idx == len) len++;
        }
        return res;
    }
}
