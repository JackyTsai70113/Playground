namespace playground.LeetCode._0000_0999;

public class _0554_LeastBricks
{
    public static int LeastBricks(IList<IList<int>> wall)
    {
        int max = 0;
        var d = new Dictionary<int, int>();
        foreach (var w in wall)
        {
            int sum = 0;
            for (int i = 0; i < w.Count - 1; i++)
            {
                sum += w[i];
                d[sum] = d.GetValueOrDefault(sum) + 1;
                max = Math.Max(max, d[sum]);
            }
        }
        return wall.Count - max;
    }
}
