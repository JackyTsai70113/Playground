namespace playground._1300_1399;

public class _1391_HasValidPath
{
    readonly Dictionary<int, (int start, int end)> d = new()
    {
        [1] = (2, 1),
        [2] = (0, 3),
        [3] = (2, 3),
        [4] = (1, 3),
        [5] = (0, 2),
        [6] = (0, 1)
    };
    public bool HasValidPath(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var q = new Queue<(int x, int y, int start, int end)>();
        q.Enqueue((0, 0, d[A[0][0]].start, d[A[0][0]].end));
        q.Enqueue((0, 0, d[A[0][0]].end, d[A[0][0]].start));
        HashSet<(int, int)> set = new();
        while (q.Count > 0)
        {
            var (x, y, start, end) = q.Dequeue();
            set.Add((x, y));
            if (x == m - 1 && y == n - 1)
                return true;
            var (moveNext, x2, y2, start2, end2) = Move(A, x, y, start, end);
            if (!moveNext)
                continue;
            if (!set.Contains((x2, y2)))
                q.Enqueue((x2, y2, start2, end2));
        }
        return false;
    }

    (bool moveNext, int x2, int y2, int start2, int end2) Move(int[][] A, int x, int y, int start, int end)
    {
        if (end == 0)
        {
            x--;
        }
        else if (end == 1)
        {
            y++;
        }
        else if (end == 2)
        {
            y--;
        }
        else
        {
            x++;
        }

        if (x < 0 || y < 0 || x == A.Length || y == A[0].Length)
            return (false, -1, -1, -1, -1);
        if (d[A[x][y]].start + end == 3)
            return (true, x, y, d[A[x][y]].start, d[A[x][y]].end);
        if (d[A[x][y]].end + end == 3)
            return (true, x, y, d[A[x][y]].end, d[A[x][y]].start);
        return (false, -1, -1, -1, -1);
    }
}
