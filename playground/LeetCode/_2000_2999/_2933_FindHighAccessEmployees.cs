namespace playground.LeetCode._2000_2999;

public class _2933_FindHighAccessEmployees
{
    /// <summary>
    /// https://leetcode.com/problems/high-access-employees
    /// </summary>
    public static IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
    {
        var ts = access_times.OrderBy(x => x[1]).ToList();
        var res = new HashSet<string>();
        var d = new Dictionary<string, List<int>>();
        foreach (var t in ts)
        {
            var min = (t[1][0] - '0') * 600 + (t[1][1] - '0') * 60 + (t[1][2] - '0') * 10 + (t[1][3] - '0');
            if (!d.ContainsKey(t[0]))
            {
                d[t[0]] = new List<int> { min };
                continue;
            }
            d[t[0]].Add(min);
            if (d[t[0]].Count >= 3 && min - d[t[0]][^3] < 60)
            {
                res.Add(t[0]);
            }
        }
        return res.ToList();
    }
}
