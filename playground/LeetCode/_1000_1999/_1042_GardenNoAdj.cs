namespace playground.LeetCode._1000_1999;

public class _1042_GardenNoAdj
{
    public static int[] GardenNoAdj(int n, int[][] paths)
    {
        var res = new int[n];
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var p in paths)
        {
            g[p[0] - 1].Add(p[1] - 1);
            g[p[1] - 1].Add(p[0] - 1);
        }
        HashSet<int> colors = new();
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= 4; j++)
                colors.Add(j);
            foreach (var v in g[i])
                colors.Remove(res[v]);
            res[i] = colors.First();
        }
        return res;
    }
}
