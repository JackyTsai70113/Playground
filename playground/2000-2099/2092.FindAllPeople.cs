namespace playground;

public class FindAllPeople2092
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-people-with-secret
    /// </summary>
    public static IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        meetings = meetings.OrderBy(m => m[2]).ToArray();
        var ds = new DisjointSet(n);
        ds.Union(0, firstPerson);
        HashSet<int> curGroup = new();
        for (int i = 0; i < meetings.Length;)
        {
            var time = meetings[i][2];
            curGroup.Clear();
            for (; i < meetings.Length && meetings[i][2] == time; i++)
            {
                var (x, y) = (meetings[i][0], meetings[i][1]);
                ds.Union(x, y);
                curGroup.Add(x);
                curGroup.Add(y);
            }

            foreach (var x in curGroup)
            {
                if (ds.Find(0) != ds.Find(x))
                {
                    ds.Ranks[ds.Find(x)]--;
                    ds.Groups[x] = x;
                }
            }
        }

        var res = new List<int> { 0 };
        int group = ds.Find(0);
        for (int i = 1; i < n; i++)
        {
            if (group == ds.Find(i))
            {
                res.Add(i);
            }
        }
        return res;
    }
}
