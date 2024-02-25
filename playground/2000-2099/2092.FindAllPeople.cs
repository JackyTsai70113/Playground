using playground.UnionFinds;

namespace playground;

public class FindAllPeople2092
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-people-with-secret
    /// </summary>
    public static IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        meetings = meetings.OrderBy(m => m[2]).ToArray();
        var uf = new UnionFind(n);
        uf.Connect(0, firstPerson);
        HashSet<int> curGroup = new();
        for (int i = 0; i < meetings.Length;)
        {
            var time = meetings[i][2];
            curGroup.Clear();
            for (; i < meetings.Length && meetings[i][2] == time; i++)
            {
                uf.Connect(meetings[i][0], meetings[i][1]);
                curGroup.Add(meetings[i][0]);
                curGroup.Add(meetings[i][1]);
            }
            foreach (var person in curGroup)
            {
                if (!uf.AreConnected(0, person))
                {
                    uf.Reset(person);
                }
            }
        }

        var res = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (uf.AreConnected(0, i))
            {
                res.Add(i);
            }
        }
        return res;
    }
}
