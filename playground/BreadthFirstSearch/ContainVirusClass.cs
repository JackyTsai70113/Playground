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
                        region.SetWallsCount(A, dirs);
                        if (region.WallsCount > 0)
                            regions.Add(region);
                    }
                }
            }

            if (regions.Count == 0)
                break;
            regions.Sort((x, y) => y.WallsCount - x.WallsCount);

            var topRegion = regions[0];
            regions.RemoveAt(0);
            res += topRegion.WallsCount;
            topRegion.StopInfection(A);

            foreach (var region in regions)
                region.Infected(A);
        }

        return res;
    }

    public class Region
    {
        public HashSet<(int x, int y)> Infecteds { get; set; } = new();
        public HashSet<(int x, int y)> UnInfecteds { get; set; } = new();
        public int WallsCount { get; set; }

        public void Construct(int[][] A, bool[,] seen, int x0, int y0, int[] dirs)
        {
            if (x0 < 0 || y0 < 0 || x0 == A.Length || y0 == A[0].Length || seen[x0, y0])
                return;
            if (A[x0][y0] == 0)
            {
                UnInfecteds.Add((x0, y0));
            }
            else if (A[x0][y0] == 1)
            {
                seen[x0, y0] = true;
                Infecteds.Add((x0, y0));
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

        public void SetWallsCount(int[][] A, int[] dirs)
        {
            WallsCount = 0;
            foreach (var (x0, y0) in Infecteds)
            {
                for (int i = 0; i < 4; i++)
                {
                    int x = x0 + dirs[i], y = y0 + dirs[i + 1];
                    if (x < 0 || y < 0 || x == A.Length || y == A[0].Length)
                        continue;
                    if (A[x][y] == 0)
                    {
                        WallsCount++;
                    }
                }
            }
        }
    }
}