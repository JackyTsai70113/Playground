namespace playground;

public class ContainVirus0749
{
    /// <summary>
    /// https://leetcode.com/problems/contain-virus
    /// </summary>
    public static int ContainVirus(int[][] A)
    {
        int[] dirs = new int[] { -1, 0, 1, 0, -1 };
        int res = 0;
        while (true)
        {
            PriorityQueue<InfectedArea, int> pq = new(Comparer<int>.Create((x, y) => y - x));
            var seen = new bool[A.Length, A[0].Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (A[i][j] == 1 && !seen[i, j])
                    {
                        var area = new InfectedArea();
                        area.Construct(A, i, j, seen, dirs);
                        if (area.UninfectedCells.Count > 0)
                        {
                            pq.Enqueue(area, area.UninfectedCells.Count);
                        }
                    }
                }
            }
            if (pq.Count == 0)
                break;
            var topArea = pq.Dequeue();
            foreach (var (x, y) in topArea.InfectedCells) // stop infection
            {
                A[x][y] = 2;
            }
            res += topArea.WallsCount;
            while (pq.Count > 0) // keep infect
            {
                foreach (var (x, y) in pq.Dequeue().UninfectedCells)
                {
                    A[x][y] = 1;
                }
            }
        }
        return res;
    }

    public class InfectedArea
    {
        public HashSet<(int x, int y)> InfectedCells = new();
        public HashSet<(int x, int y)> UninfectedCells = new();
        public int WallsCount = 0;
        public void Construct(int[][] A, int x, int y, bool[,] seen, int[] dirs)
        {
            if (x < 0 || y < 0 || x == A.Length || y == A[0].Length || A[x][y] == 2)
                return;
            if (A[x][y] == 0)
            {
                UninfectedCells.Add((x, y));
                WallsCount++;
            }
            else
            {
                InfectedCells.Add((x, y));
                if (seen[x, y])
                    return;
                seen[x, y] = true;
                for (int i = 0; i < 4; i++)
                {
                    Construct(A, x + dirs[i], y + dirs[i + 1], seen, dirs);
                }
            }
        }
    }
}
