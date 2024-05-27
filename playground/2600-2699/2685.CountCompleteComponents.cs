namespace playground;

public class CountCompleteComponents2685
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-complete-components
    /// </summary>
    public static int CountCompleteComponents(int n, int[][] edges)
    {
        int[] edgeCounts = new int[n];
        var ds = new DisjointSet(n);
        foreach (var e in edges)
        {
            int g1 = ds.Find(e[0]), g2 = ds.Find(e[1]);
            int count1 = edgeCounts[g1], count2 = edgeCounts[g2];
            if (g1 != g2)
            {
                ds.Union(e[0], e[1]);
                g1 = ds.Find(e[0]);
                edgeCounts[g1] = count1 + count2 + 1;
            }
            else
            {
                edgeCounts[g1]++;
            }
        }

        var res = 0;
        for (int i = 0; i < n; i++)
        {
            var g = ds.Find(i);
            if (g != i) continue;
            if (edgeCounts[g] == ds.Ranks[g] * (ds.Ranks[g] - 1) / 2)
                res++;
        }
        return res;
    }
}