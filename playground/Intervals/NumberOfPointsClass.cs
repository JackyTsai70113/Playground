namespace playground.Intervals;

public class NumberOfPointsClass
{
    /// <summary>
    /// https://leetcode.com/problems/points-that-intersect-with-cars
    /// </summary>
    public static int NumberOfPoints(IList<IList<int>> nums)
    {
        var l = nums.ToList();
        l.Sort((x, y) =>
        {
            if (x[0] == y[0])
                return x[1] - y[1];
            return x[0] - y[0];
        });
        var l2 = new List<IList<int>> { l[0] };
        var res = 0;
        for (int i = 1; i < l.Count; ++i)
        {
            if (l2[^1][1] >= l[i][0])
            {
                l2[^1][1] = Math.Max(l2[^1][1], l[i][1]);
            }
            else
            {
                res += l2[^1][1] - l2[^1][0] + 1;
                l2.Add(l[i]);
            }
        }
        res += l2[^1][1] - l2[^1][0] + 1;
        return res;
    }


}
