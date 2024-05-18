namespace playground;

public class MaximumSafenessFactor2812
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-safest-path-in-a-grid
    /// </summary>
    public static int MaximumSafenessFactor(IList<IList<int>> A)
    {
        int n = A.Count;
        if (A[0][0] == 1 || A[n - 1][n - 1] == 1)
            return 0;
        SetFactor(A);

        var dirs = new int[] { -1, 0, 1, 0, -1 };
        var pq = new PriorityQueue<(int, int), int>();
        var seen = new bool[n, n];
        pq.Enqueue((0, 0), -A[0][0]);
        seen[0, 0] = true;
        int min = A[0][0] - 1;
        while (pq.Count > 0)
        {
            var (r0, c0) = pq.Dequeue();
            min = Math.Min(min, A[r0][c0] - 1);
            if (r0 == n - 1 && c0 == n - 1)
                break;
            for (int i = 0; i < 4; i++)
            {
                var (r, c) = (r0 + dirs[i], c0 + dirs[i + 1]);
                if (r < 0 || c < 0 || r == n || c == n || seen[r, c])
                    continue;
                seen[r, c] = true;
                pq.Enqueue((r, c), -A[r][c]);
            }
        }

        return min;
    }

    public static void SetFactor(IList<IList<int>> A)
    {
        int n = A.Count;
        var pq = new PriorityQueue<(int, int), int>();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (A[i][j] == 1)
                    pq.Enqueue((i, j), 1);
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        while (pq.Count > 0)
        {
            var (r0, c0) = pq.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                var (r, c) = (r0 + dirs[i], c0 + dirs[i + 1]);
                if (r < 0 || c < 0 || r == n || c == n || A[r][c] != 0 && A[r][c] <= A[r0][c0] + 1)
                    continue;
                A[r][c] = A[r0][c0] + 1;
                pq.Enqueue((r, c), A[r][c]);
            }
        }
    }
}
