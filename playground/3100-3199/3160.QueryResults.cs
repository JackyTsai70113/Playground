namespace playground;

public class QueryResults3160
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-number-of-distinct-colors-among-the-balls/
    /// </summary>
    public static int[] QueryResults(int limit, int[][] queries)
    {
        var ball = new Dictionary<int, int>();
        var color = new Dictionary<int, int>();
        var res = new List<int>();
        var count = 0;
        foreach (var q in queries)
        {
            if (ball.ContainsKey(q[0]))
            {
                color[ball[q[0]]]--;
                if (color[ball[q[0]]] == 0)
                    count--;
            }
            ball[q[0]] = q[1];
            color[q[1]] = color.ContainsKey(q[1]) ? color[q[1]] + 1 : 1;
            if (color[q[1]] == 1)
                count++;
            res.Add(count);
        }
        return res.ToArray();
    }
}
