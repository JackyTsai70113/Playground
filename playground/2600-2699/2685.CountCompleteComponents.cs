namespace playground;

public class CountCompleteComponents2685
{
    public static int CountCompleteComponents(int n, int[][] edges)
    {
        int[] edgeCount = new int[n];
        var ds = new DisjointSet(n);
        foreach (var e in edges)
        {
            int g1 = ds.Find(e[0]), g2 = ds.Find(e[1]);
            int count1 = edgeCount[g1], count2 = edgeCount[g2];
            if (g1 != g2)
            {
                ds.Join(e[0], e[1]);
                g1 = ds.Find(e[0]);
                edgeCount[g1] = count1 + count2 + 1;
            }
            else
            {
                edgeCount[g1]++;
            }
        }

        var res = 0;
        for (int i = 0; i < n; i++)
        {
            var g = ds.Find(i);
            if (g != i) continue;
            if (edgeCount[g] == ds.rs[g] * (ds.rs[g] - 1) / 2)
                res++;
        }
        return res;
    }
}