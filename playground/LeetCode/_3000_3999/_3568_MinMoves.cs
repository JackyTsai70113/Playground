namespace playground.LeetCode._3000_3999;

public class _3568_MinMoves
{
    public static int MinMoves(string[] A, int energy)
    {
        int m = A.Length, n = A[0].Length;
        var (start, litters) = FindStartAndLitters(A);
        var seen = new bool[m, n, energy + 1, 1 << litters.Count];
        var q = new Queue<(int r, int c, int e, int litterMask)>();

        q.Enqueue((start[0], start[1], energy, 0));
        seen[start[0], start[1], energy, 0] = true;

        var dirs = new int[] { 1, 0, -1, 0, 1 };
        int steps = 0;

        while (q.Count > 0)
        {
            int size = q.Count;
            while (size-- > 0)
            {
                var (r, c, e, litterMask) = q.Dequeue();
                if (AllLittersCollected(litterMask, litters.Count))
                    return steps;

                if (e == 0) continue;

                for (int d = 0; d < 4; d++)
                {
                    int rr = r + dirs[d];
                    int cc = c + dirs[d + 1];

                    if (!IsValidCell(rr, cc, m, n) || A[rr][cc] == 'X')
                        continue;

                    int nextLitter = UpdateLitterBitmask(rr, cc, litterMask, litters);
                    int nextEnergy = GetNextEnergy(A[rr][cc], e, energy);

                    if (seen[rr, cc, nextEnergy, nextLitter])
                        continue;

                    seen[rr, cc, nextEnergy, nextLitter] = true;
                    q.Enqueue((rr, cc, nextEnergy, nextLitter));
                }
            }
            steps++;
        }

        return -1;
    }

    private static (int[] start, List<int[]> litters) FindStartAndLitters(string[] A)
    {
        var start = new int[2];
        var litters = new List<int[]>();
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                if (A[i][j] == 'S')
                    start = new[] { i, j };
                else if (A[i][j] == 'L')
                    litters.Add(new int[] { i, j });
            }
        }
        return (start, litters);
    }

    private static bool IsValidCell(int r, int c, int m, int n)
        => r >= 0 && c >= 0 && r < m && c < n;

    private static int UpdateLitterBitmask(int r, int c, int currentMask, List<int[]> litters)
    {
        for (int i = 0; i < litters.Count; i++)
        {
            if (r == litters[i][0] && c == litters[i][1])
                currentMask |= 1 << i;
        }
        return currentMask;
    }

    private static int GetNextEnergy(char cell, int current, int maxEnergy)
        => cell == 'R' ? maxEnergy : current - 1;

    private static bool AllLittersCollected(int mask, int litterCount)
        => mask == (1 << litterCount) - 1;
}
