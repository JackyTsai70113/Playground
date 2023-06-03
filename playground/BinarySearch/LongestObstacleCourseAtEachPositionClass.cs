namespace playground.BinarySearch;

public class LongestObstacleCourseAtEachPositionClass
{
    /// <remarks>https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position</remarks>
    public static int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        var d = new Dictionary<int, int>();
        var l = new List<int>();
        var res = new List<int>();
        foreach (var ob in obstacles)
        {
            if (!d.ContainsKey(ob))
            {
                var idx = BinarySearchTemplateClass.GetUpperBound(l.ToArray(), ob);
                if (idx < l.Count && l[idx] <= ob)
                    idx++;
                if (idx == l.Count)
                    l.Add(ob);
                else
                {
                    if (ob < l[idx])
                    {
                        d.Remove(l[idx]);
                        l[idx] = ob;
                    }
                }
                d[ob] = idx + 1;
            }
            else
            {
                var idx = d[ob];
                if (idx == l.Count)
                    l.Add(ob);
                else
                {
                    if (ob < l[idx])
                    {
                        d.Remove(l[idx]);
                        l[idx] = ob;
                    }
                }
                d[ob]++;
            }
            res.Add(d[ob]);
        }
        return res.ToArray();
    }

    /// <remarks>https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position/</remarks>
    public static int[] LongestObstacleCourseAtEachPosition2(int[] obstacles)
    {
        int n = obstacles.Length, len = 0;
        int[] res = new int[n], sub = new int[n];
        for (int i = 0; i < n; i++)
        {
            // 取得大於給定範圍內 sub 的第一個數的 index
            int idx = BinarySearchTemplateClass.GetLowerBound(sub, 0, len, (val) => val > obstacles[i]);
            sub[idx] = obstacles[i];
            res[i] = idx + 1;
            if (idx == len)
                len++;
        }
        return res;
    }
}
