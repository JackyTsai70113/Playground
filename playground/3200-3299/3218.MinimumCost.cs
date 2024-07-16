namespace playground;

public class MinimumCost3218
{
    public static int MinimumCost(int m, int n, int[] A, int[] B)
    {
        List<(int cost, int type)> cuts = new();
        foreach (var a in A) cuts.Add((a, 0));
        foreach (var b in B) cuts.Add((b, 1));
        cuts.Sort((x, y) => y.cost - x.cost);
        int totalCost = 0;
        int hCount = 1, vCount = 1;
        foreach (var cut in cuts)
        {
            if (cut.type == 0)
            {
                totalCost += cut.cost * vCount;
                hCount++;
            }
            else
            {
                totalCost += cut.cost * hCount;
                vCount++;
            }
        }
        return totalCost;
    }
}
