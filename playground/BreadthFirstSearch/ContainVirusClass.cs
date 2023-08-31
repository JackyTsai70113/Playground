namespace playground.BreadthFirstSearch;

public class ContainVirusClass
{
    /// <remarks>https://leetcode.com/problems/contain-virus</remarks>
    public static int ContainVirus(int[][] A)
    {
        int[] dirs = new int[] { -1, 0, 1, 0, -1 };
        var res = 0;
        while (true)
        {
            List<Region> regions = new();
            var seen = new bool[A.Length, A[0].Length];
            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (A[i][j] == 1 && !seen[i, j])
                    {
                        var region = new Region();
                        region.Construct(A, seen, i, j, dirs);
                        if (region.CanInfected())
                            regions.Add(region);
                    }
                }
            }

            if (regions.Count == 0)
                break;

            regions.Sort();

            var topRegion = regions[0];
            regions.RemoveAt(0);
            res += topRegion.GetWallsCount();
            topRegion.StopInfection(A);

            foreach (var region in regions)
                region.Infected(A);
        }

        return res;
    }
}

internal class Region : IComparable<Region>
{
    public HashSet<(int x, int y)> Infecteds { get; set; } = new();
    public HashSet<(int x, int y)> UnInfecteds { get; set; } = new();
    public int WallsCount { get; private set; }

    public void Construct(int[][] A, bool[,] seen, int x0, int y0, int[] dirs)
    {
        if (x0 < 0 || y0 < 0 || x0 == A.Length || y0 == A[0].Length || A[x0][y0] == 2)
            return;
        if (A[x0][y0] == 0)
        {
            UnInfecteds.Add((x0, y0));
            WallsCount++;
        }
        else if (A[x0][y0] == 1)
        {
            Infecteds.Add((x0, y0));
            if (seen[x0, y0])
                return;
            seen[x0, y0] = true;
            for (int i = 0; i < 4; i++)
            {
                Construct(A, seen, x0 + dirs[i], y0 + dirs[i + 1], dirs);
            }
        }
    }

    public void StopInfection(int[][] A)
    {
        foreach (var (x0, y0) in Infecteds)
            A[x0][y0] = 2;
    }

    public void Infected(int[][] A)
    {
        foreach (var (x0, y0) in UnInfecteds)
            A[x0][y0] = 1;
    }

    public bool CanInfected()
    {
        return UnInfecteds.Count > 0;
    }

    public int GetWallsCount()
    {
        return WallsCount;
    }

    public int CompareTo(Region other)
    {
        return other.UnInfecteds.Count - UnInfecteds.Count;
    }
}